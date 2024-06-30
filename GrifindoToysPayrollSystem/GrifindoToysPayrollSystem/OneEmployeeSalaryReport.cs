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
    
    public partial class OneEmployeeSalaryReport : Form
    {
        private string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
        public OneEmployeeSalaryReport()
        {
            InitializeComponent();
            LoadEmployeeIds();
        }
        private void LoadEmployeeIds()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeID, EmployeeName FROM EmpDetails"; // Getting EmployeeID and EmployeeName from table
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Populate the combo box with employee IDs and names
                    while (reader.Read())
                    {
                        string employeeID = reader["EmployeeID"].ToString();
                        string employeeName = reader["EmployeeName"].ToString();
                        cmbEmployeeId.Items.Add(new ComboBoxItem(employeeID, employeeName));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void OneEmployeeSalaryReport_Load(object sender, EventArgs e)
        {

        }

        // Method to display an employee's salary for a specific month
        private void DisplayEmployeeSalaries(string employeeID, DateTime date, Label basePayLabel, Label noPayLabel, Label grossPayLabel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT ISNULL(BasePay, 0) AS BasePay, ISNULL(NoPay, 0) AS NoPay, ISNULL(GrossPay, 0) AS GrossPay
                                 FROM Salary
                                 WHERE EmployeeID = @EmployeeID AND YEAR(BeginDate) = @Year AND MONTH(BeginDate) = @Month";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@Year", date.Year);
                command.Parameters.AddWithValue("@Month", date.Month);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal basePay = reader.IsDBNull(reader.GetOrdinal("BasePay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("BasePay"));
                        decimal noPay = reader.IsDBNull(reader.GetOrdinal("NoPay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("NoPay"));
                        decimal grossPay = reader.IsDBNull(reader.GetOrdinal("GrossPay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("GrossPay"));

                        if (basePay == 0 && noPay == 0 && grossPay == 0)
                        {
                            MessageBox.Show("No data available for the selected month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        basePayLabel.Text = basePay.ToString("0.00");
                        noPayLabel.Text = noPay.ToString("0.00");
                        grossPayLabel.Text = grossPay.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("No data available for the selected month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching salaries: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to display an employee's salary within a specific date range
        private void DisplayEmployeeSalariesInRange(string employeeID, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT ISNULL(SUM(BasePay), 0) AS TotalBasePay, ISNULL(SUM(NoPay), 0) AS TotalNoPay, ISNULL(SUM(GrossPay), 0) AS TotalGrossPay
                                 FROM Salary
                                 WHERE EmployeeID = @EmployeeID AND (YEAR(BeginDate) * 100 + MONTH(BeginDate)) >= @StartYearMonth 
                                 AND (YEAR(EndDate) * 100 + MONTH(EndDate)) <= @EndYearMonth";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@StartYearMonth", startDate.Year * 100 + startDate.Month);
                command.Parameters.AddWithValue("@EndYearMonth", endDate.Year * 100 + endDate.Month);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalBasePay = reader.IsDBNull(reader.GetOrdinal("TotalBasePay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalBasePay"));
                        decimal totalNoPay = reader.IsDBNull(reader.GetOrdinal("TotalNoPay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalNoPay"));
                        decimal totalGrossPay = reader.IsDBNull(reader.GetOrdinal("TotalGrossPay")) ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalGrossPay"));

                        if (totalBasePay == 0 && totalNoPay == 0 && totalGrossPay == 0)
                        {
                            MessageBox.Show("No data available for the selected period.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        lblRangeBasePay.Text = totalBasePay.ToString("0.00");
                        lblRangeNoPay.Text = totalNoPay.ToString("0.00");
                        lblRangeGrossPay.Text = totalGrossPay.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("No data available for the selected period.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching salaries: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Class to represent items in the combo box
        public class ComboBoxItem
        {
            public string ID { get; }
            public string Name { get; }

            public ComboBoxItem(string id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"{ID} - {Name}";
            }
        }



        private void btnSingleMonth1_Click_1(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cmbEmployeeId.SelectedItem;
            string employeeID = selectedItem.ID;
            DateTime selectedDate = dtpSingleMonth1.Value;
            DisplayEmployeeSalaries(employeeID, selectedDate, lblSingleMonth1BasePay, lblSingleMonth1NoPay, lblSingleMonth1GrossPay);
        }

        private void btnSingleMonth2_Click_1(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cmbEmployeeId.SelectedItem;
            string employeeID = selectedItem.ID;
            DateTime selectedDate = dtpSingleMonth2.Value;
            DisplayEmployeeSalaries(employeeID, selectedDate, lblSingleMonth2BasePay, lblSingleMonth2NoPay, lblSingleMonth2GrossPay);
        }


        private void btnRange_Click_Click_1(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cmbEmployeeId.SelectedItem;
            string employeeID = selectedItem.ID;
            DateTime startDate = dtpRangeStart.Value;
            DateTime endDate = dtpRangeEnd.Value;
            DisplayEmployeeSalariesInRange(employeeID, startDate, endDate);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
