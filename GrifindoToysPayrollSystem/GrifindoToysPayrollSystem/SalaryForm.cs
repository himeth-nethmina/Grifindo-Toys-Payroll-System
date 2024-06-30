using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoToysPayrollSystem
{
    public partial class SalaryForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True");

        public SalaryForm()
        {
            InitializeComponent();
            LoadEmployeeIDs();
            LockDateFields();
            txtLeavesPerYear.ReadOnly = true;
            txtAvailableLeaves.ReadOnly = true;
            txtOverrunLeaves.ReadOnly = true;
            
            LoadCurrentSettings();
            txtLeaveCount.ReadOnly = true;
        }

        private void LoadEmployeeIDs()
        {
            string query = "SELECT EmployeeID FROM EmpDetails";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbEmployeeID.Items.Add(reader["EmployeeID"].ToString());
            }
            conn.Close();
        }
        private void LockDateFields()
        {
            dtpBeginDate.Enabled = false;
            dtpEndDate.Enabled = false;
        }


        private void LoadCurrentSettings()
        {
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SalaryCycleBeginDate, SalaryCycleEndDate FROM Settings";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dtpBeginDate.Value = (DateTime)reader["SalaryCycleBeginDate"];
                            dtpEndDate.Value = (DateTime)reader["SalaryCycleEndDate"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading current settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SalaryForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtOvertimeRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonthlySalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAllowance_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllEmployeesSalaryReport allEmployeesSalaryReport = new AllEmployeesSalaryReport();
            allEmployeesSalaryReport.Show();
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex <= 0)
            {
                lblEmployeeName.Text = string.Empty;
                txtLeavesPerYear.Text = string.Empty;
                txtAvailableLeaves.Text = string.Empty;
                txtOverrunLeaves.Text = string.Empty;
                txtLeaveCount.Text = string.Empty;
                return;
            }

            string employeeID = cmbEmployeeID.SelectedItem.ToString();
            int currentYear = DateTime.Now.Year;
            int leavesPerYear = GetLeavesPerYear();
            int totalLeaveDays = GetTotalLeaveDaysForYear(employeeID, currentYear);
            int availableLeaves = leavesPerYear - totalLeaveDays;
            int overrunLeaves = totalLeaveDays > leavesPerYear ? totalLeaveDays - leavesPerYear : 0;

            txtLeavesPerYear.Text = leavesPerYear.ToString();
            txtAvailableLeaves.Text = availableLeaves.ToString();
            txtOverrunLeaves.Text = overrunLeaves.ToString();
            txtLeaveCount.Text = totalLeaveDays.ToString();

            // Load employee name
            string query = "SELECT EmployeeName FROM EmpDetails WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblEmployeeName.Text = reader["EmployeeName"].ToString();
            }
            conn.Close();
        }
        private int GetLeavesPerYear()
        {
            string query = "SELECT TOP 1 LeavesPerYear FROM Settings ORDER BY SettingID DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            int leavesPerYear = (int)cmd.ExecuteScalar();
            conn.Close();

            return leavesPerYear;
        }

        private int GetTotalLeaveDaysForYear(string employeeID, int year)
        {
            string query = "SELECT ISNULL(SUM(LeavingDays), 0) FROM Leave WHERE EmployeeID = @EmployeeID AND YEAR(LeaveDate) = @Year";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            cmd.Parameters.AddWithValue("@Year", year);

            conn.Open();
            int totalLeaveDays = (int)cmd.ExecuteScalar();
            conn.Close();

            return totalLeaveDays;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(txtLeaveCount.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfAbsentDays.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfHolidays.Text) ||
                string.IsNullOrWhiteSpace(txtOvertimeHours.Text))
            {
                MessageBox.Show("Please fill in the number of leaves, absent days, holidays, and overtime work hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use TryParse to avoid FormatException
            string employeeID = cmbEmployeeID.SelectedItem.ToString();
            int leaves, absentDays, holidays, overtimeHours;
            if (!int.TryParse(txtLeaveCount.Text, out leaves) ||
                !int.TryParse(txtNumberOfAbsentDays.Text, out absentDays) ||
                !int.TryParse(txtNumberOfHolidays.Text, out holidays) ||
                !int.TryParse(txtOvertimeHours.Text, out overtimeHours))
            {
                MessageBox.Show("Please enter valid numbers for leaves, absent days, holidays, and overtime hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate additional absent days if leaves exceed LeavesPerYear
            int leavesPerYear = int.Parse(txtLeavesPerYear.Text);
            if (leaves > leavesPerYear)
            {
                absentDays += (leaves - leavesPerYear);
                leaves = leavesPerYear;
            }

            string query = "SELECT MonthlySalary, Allowance, Overtimerate FROM EmpDetails WHERE EmployeeID = @EmployeeID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    decimal monthlySalary = 0, allowance = 0, overtimeRate = 0;
                    if (reader.Read())
                    {
                        monthlySalary = (decimal)reader["MonthlySalary"];
                        allowance = (decimal)reader["Allowance"];
                        overtimeRate = (decimal)reader["Overtimerate"];
                    }
                    conn.Close();

                    decimal basePay = monthlySalary + allowance + (overtimeRate * overtimeHours);
                    decimal dateRange = GetSalaryCycleDateRange();
                    decimal noPay = (monthlySalary / dateRange) * absentDays;
                    decimal governmentTaxRate = GetGovernmentTaxRate();
                    decimal grossPay = basePay - (noPay + (basePay * governmentTaxRate / 100));

                    lblBasePay.Text = basePay.ToString("C");
                    lblNoPay.Text = noPay.ToString("C");
                    lblGrossPay.Text = grossPay.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating salary: " + ex.Message);
                    conn.Close();
                }
            }
        }


        private decimal GetSalaryCycleDateRange()
        {
            string query = "SELECT TOP 1 DateRangeForSalaryCycle FROM Settings ORDER BY SettingID DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            int dateRange = (int)cmd.ExecuteScalar();
            conn.Close();

            return dateRange;
        }
        private decimal GetGovernmentTaxRate()
        {
            string query = "SELECT TOP 1 GovernmentTaxRate FROM Settings ORDER BY SettingID DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            decimal taxRate = (decimal)cmd.ExecuteScalar();
            conn.Close();

            return taxRate;
        }





        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLeaveCount.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfAbsentDays.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfHolidays.Text) ||
                string.IsNullOrWhiteSpace(txtOvertimeHours.Text) ||
                string.IsNullOrWhiteSpace(lblBasePay.Text) ||
                string.IsNullOrWhiteSpace(lblNoPay.Text) ||
                string.IsNullOrWhiteSpace(lblGrossPay.Text))
            {
                MessageBox.Show("Please fill in all fields and calculate pay before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeID = cmbEmployeeID.SelectedItem.ToString();
            DateTime beginDate = dtpBeginDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int leaves = int.Parse(txtLeaveCount.Text);
            int absentDays = int.Parse(txtNumberOfAbsentDays.Text);
            int holidays = int.Parse(txtNumberOfHolidays.Text);
            int overtimeHours = int.Parse(txtOvertimeHours.Text);
            decimal basePay = decimal.Parse(lblBasePay.Text, System.Globalization.NumberStyles.Currency);
            decimal noPay = decimal.Parse(lblNoPay.Text, System.Globalization.NumberStyles.Currency);
            decimal grossPay = decimal.Parse(lblGrossPay.Text, System.Globalization.NumberStyles.Currency);

            string query = "INSERT INTO Salary (EmployeeID, BeginDate, EndDate, NumberOfLeaves, NumberOfAbsentDays, NumberOfHolidays, Overtimehours, BasePay, NoPay, GrossPay) " +
                           "VALUES (@EmployeeID, @BeginDate, @EndDate, @Leaves, @AbsentDays, @Holidays, @Overtimehours, @BasePay, @NoPay, @GrossPay)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            cmd.Parameters.AddWithValue("@BeginDate", beginDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.Parameters.AddWithValue("@Leaves", leaves);
            cmd.Parameters.AddWithValue("@AbsentDays", absentDays);
            cmd.Parameters.AddWithValue("@Holidays", holidays);
            cmd.Parameters.AddWithValue("@Overtimehours", overtimeHours);
            cmd.Parameters.AddWithValue("@BasePay", basePay);
            cmd.Parameters.AddWithValue("@NoPay", noPay);
            cmd.Parameters.AddWithValue("@GrossPay", grossPay);

            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Salary details saved successfully.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error saving salary details.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Salary details for this date range already exist for the selected employee.");
                }
                else
                {
                    MessageBox.Show("An error occurred while saving salary details: " + ex.Message);
                }
                conn.Close();
            }
        }
        private void ClearForm()
        {
            cmbEmployeeID.SelectedIndex = -1;
            lblEmployeeName.Text = string.Empty;
            txtLeaveCount.Clear();
            txtNumberOfAbsentDays.Clear();
            txtNumberOfHolidays.Clear();
            txtOvertimeHours.Clear();
            lblBasePay.Text = string.Empty;
            lblNoPay.Text = string.Empty;
            lblGrossPay.Text = string.Empty;
        }
        private void ResetComboBox()
        {
            cmbEmployeeID.SelectedIndex = 0; // Reset to "Select ID"
            lblEmployeeName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OneEmployeeSalaryReport oneEmployeeSalaryReport = new OneEmployeeSalaryReport();
            oneEmployeeSalaryReport.Show();
        }

        private void btnExitCurrent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalaryIn_Click(object sender, EventArgs e)
        {
            AllEmployeesSalaryReport allEmployeesSalaryReport = new AllEmployeesSalaryReport();
            allEmployeesSalaryReport.Show();
        }

        private void btnSalIn_Click(object sender, EventArgs e)
        {
            OneEmployeeSalaryReport oneEmployeeSalaryReport = new OneEmployeeSalaryReport();
            oneEmployeeSalaryReport.Show();
        }

        private void btnSalCal_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(txtLeaveCount.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfAbsentDays.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfHolidays.Text) ||
                string.IsNullOrWhiteSpace(txtOvertimeHours.Text))
            {
                MessageBox.Show("Please fill in the number of leaves, absent days, holidays, and overtime work hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use TryParse to avoid FormatException
            string employeeID = cmbEmployeeID.SelectedItem.ToString();
            int leaves, absentDays, holidays, overtimeHours;
            if (!int.TryParse(txtLeaveCount.Text, out leaves) ||
                !int.TryParse(txtNumberOfAbsentDays.Text, out absentDays) ||
                !int.TryParse(txtNumberOfHolidays.Text, out holidays) ||
                !int.TryParse(txtOvertimeHours.Text, out overtimeHours))
            {
                MessageBox.Show("Please enter valid numbers for leaves, absent days, holidays, and overtime hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate additional absent days if leaves exceed LeavesPerYear
            int leavesPerYear = int.Parse(txtLeavesPerYear.Text);
            if (leaves > leavesPerYear)
            {
                absentDays += (leaves - leavesPerYear);
                leaves = leavesPerYear;
            }

            string query = "SELECT MonthlySalary, Allowance, Overtimerate FROM EmpDetails WHERE EmployeeID = @EmployeeID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    decimal monthlySalary = 0, allowance = 0, overtimeRate = 0;
                    if (reader.Read())
                    {
                        monthlySalary = (decimal)reader["MonthlySalary"];
                        allowance = (decimal)reader["Allowance"];
                        overtimeRate = (decimal)reader["Overtimerate"];
                    }
                    conn.Close();

                    decimal basePay = monthlySalary + allowance + (overtimeRate * overtimeHours);
                    decimal dateRange = GetSalaryCycleDateRange();
                    decimal noPay = (monthlySalary / dateRange) * absentDays;
                    decimal governmentTaxRate = GetGovernmentTaxRate();
                    decimal grossPay = basePay - (noPay + (basePay * governmentTaxRate / 100));

                    lblBasePay.Text = basePay.ToString("C");
                    lblNoPay.Text = noPay.ToString("C");
                    lblGrossPay.Text = grossPay.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating salary: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSaveSal_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLeaveCount.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfAbsentDays.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfHolidays.Text) ||
                string.IsNullOrWhiteSpace(txtOvertimeHours.Text) ||
                string.IsNullOrWhiteSpace(lblBasePay.Text) ||
                string.IsNullOrWhiteSpace(lblNoPay.Text) ||
                string.IsNullOrWhiteSpace(lblGrossPay.Text))
            {
                MessageBox.Show("Please fill in all fields and calculate pay before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeID = cmbEmployeeID.SelectedItem.ToString();
            DateTime beginDate = dtpBeginDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int leaves = int.Parse(txtLeaveCount.Text);
            int absentDays = int.Parse(txtNumberOfAbsentDays.Text);
            int holidays = int.Parse(txtNumberOfHolidays.Text);
            int overtimeHours = int.Parse(txtOvertimeHours.Text);
            decimal basePay = decimal.Parse(lblBasePay.Text, System.Globalization.NumberStyles.Currency);
            decimal noPay = decimal.Parse(lblNoPay.Text, System.Globalization.NumberStyles.Currency);
            decimal grossPay = decimal.Parse(lblGrossPay.Text, System.Globalization.NumberStyles.Currency);

            string query = "INSERT INTO Salary (EmployeeID, BeginDate, EndDate, NumberOfLeaves, NumberOfAbsentDays, NumberOfHolidays, Overtimehours, BasePay, NoPay, GrossPay) " +
                           "VALUES (@EmployeeID, @BeginDate, @EndDate, @Leaves, @AbsentDays, @Holidays, @Overtimehours, @BasePay, @NoPay, @GrossPay)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
            cmd.Parameters.AddWithValue("@BeginDate", beginDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.Parameters.AddWithValue("@Leaves", leaves);
            cmd.Parameters.AddWithValue("@AbsentDays", absentDays);
            cmd.Parameters.AddWithValue("@Holidays", holidays);
            cmd.Parameters.AddWithValue("@Overtimehours", overtimeHours);
            cmd.Parameters.AddWithValue("@BasePay", basePay);
            cmd.Parameters.AddWithValue("@NoPay", noPay);
            cmd.Parameters.AddWithValue("@GrossPay", grossPay);

            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Salary details saved successfully.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error saving salary details.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Salary details for this date range already exist for the selected employee.");
                }
                else
                {
                    MessageBox.Show("An error occurred while saving salary details: " + ex.Message);
                }
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

    