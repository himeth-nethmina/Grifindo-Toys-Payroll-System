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
    public partial class EmployeeForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
        private int nextEmployeeID = 0;

        public EmployeeForm()
        {
            InitializeComponent();
            LoadNextEmployeeID();
            SetDefaultState();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            
        }
        // Method to generate a new Employee ID
        private void LoadNextEmployeeID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 NextEmployeeID FROM EmployeeIDGenerator";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    nextEmployeeID = Convert.ToInt32(result);
                    lblEmployeeID.Text = "GTE-" + nextEmployeeID.ToString("D4");
                }
                else
                {
                    MessageBox.Show("Failed to retrieve next Employee ID from database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update the next available Employee ID in the database
        private void UpdateNextEmployeeID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE EmployeeIDGenerator SET NextEmployeeID = {nextEmployeeID + 1}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    nextEmployeeID++; // Increment locally if update successful
                }
                else
                {
                    MessageBox.Show("Failed to update next Employee ID in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SetDefaultState()
        {
            btnDel.Visible = false;
            btnUp.Visible = false;
            btnSav.Visible = true;
            cmbEmployeeID.Visible = false;
            
            
            
            
        }

        // Method to clear form fields
        private void ClearFormFields()
        {
            txtEmployeeName.Clear();
            txtNIC.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            rbMale.Checked = false;
            cmbCivilStatus.SelectedIndex = -1;
            txtMonthlySalary.Clear();
            txtOvertimeRate.Clear();
            txtAllowance.Clear();
            
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }



        // Validate the NIC
        private bool IsNicValid(string nic)
        {
            // NIC should be exactly 10 characters (old format) or 12 characters (new format), and it should be numbers
            return (nic.Length == 9 || nic.Length == 12) && nic.All(char.IsDigit);
        }
        // Validate the Contact Number
        private bool IsContactNumberValid(string contactNumber)
        {
            // Contact number should be exactly 10 digits and only contain numeric characters
            return contactNumber.Length == 10 && contactNumber.All(char.IsDigit);
        }




        private void cmbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        // Change text color based on NIC length
        private void txtNIC_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNIC.Text.Length == 9 || txtNIC.Text.Length == 12)
            {
                txtNIC.ForeColor = Color.Green;
            }
            else
            {
                txtNIC.ForeColor = Color.Red;
            }
        }

        // Change text color based on length of contact number
        private void txtContactNumber_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContactNumber.Text.Length == 10)
            {
                txtContactNumber.ForeColor = Color.Green;
            }
            else
            {
                txtContactNumber.ForeColor = Color.Red;
            }
        }

       
   


        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)

        {
            try
            {
                if (cmbEmployeeID.SelectedIndex >= 0)
                {
                    string employeeID = cmbEmployeeID.SelectedItem.ToString();
                    string query = "SELECT * FROM EmpDetails WHERE EmployeeID='" + employeeID + "'";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            lblEmployeeID.Text = reader["EmployeeID"].ToString();
                            txtEmployeeName.Text = reader["EmployeeName"].ToString();
                            txtNIC.Text = reader["NIC"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            dtpDateOfBirth.Text = reader["DateOfBirth"].ToString();
                            string gender = reader["Gender"].ToString();
                            cmbCivilStatus.SelectedItem = reader["CivilStatus"].ToString();
                            txtMonthlySalary.Text = reader["MonthlySalary"].ToString();
                            txtOvertimeRate.Text = reader["OvertimeRate"].ToString();
                            txtAllowance.Text = reader["Allowance"].ToString();

                            if (gender.Equals("Male")) { rbMale.Checked = true; }
                            else if (gender.Equals("Female")) { rbFemale.Checked = true; }
                        }
                        connection.Close();
                    }

                    btnSav.Visible = false;
                    btnDel.Visible = true;
                    btnUp.Visible = true;
                    btnCl.Visible = true;
                 
                    
                    
                    
                    
                    
                }
                else
                {
                    ClearForm();
                }
            }
            catch (Exception SelErr)
            {
                MessageBox.Show("Error while Selecting..." + Environment.NewLine + SelErr);
            }
        }

        private void ClearForm()
        {
            lblEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtNIC.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            dtpDateOfBirth.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cmbCivilStatus.SelectedIndex = 0;
            txtMonthlySalary.Text = "";
            txtOvertimeRate.Text = "";
            txtAllowance.Text = "";
        }


        

        private void clear()
        {
            lblEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtNIC.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            dtpDateOfBirth.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cmbCivilStatus.SelectedIndex = 0;
            txtMonthlySalary.Text = "";
            txtOvertimeRate.Text = "";
            txtAllowance.Text = "";
            cmbEmployeeID.SelectedIndex = -1;

        }

        // Check if all fields are filled
        private bool AreAllFieldsFilled()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(((TextBox)control).Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
        }
        private bool IsValidNIC(string nic)
        {
            return (nic.Length == 9 || nic.Length == 12) && nic.All(char.IsDigit);
        }


        private bool IsValidContactNumber(string contactNumber)
        {
            return contactNumber.Length == 10 && contactNumber.All(char.IsDigit);
        }
        private bool IsGenderSelected()
        {
            return rbMale.Checked || rbFemale.Checked;
        }
        private bool ValidateInputs()
        {
            if (!IsValidNIC(txtNIC.Text) || !IsValidContactNumber(txtContactNumber.Text) || !IsValidDecimal(txtMonthlySalary.Text) || !IsValidDecimal(txtOvertimeRate.Text) || !IsValidDecimal(txtAllowance.Text))
            {
                return false;
            }
            return true;
        }

        private bool IsValidDecimal(string input)
        {
            decimal result;
            return decimal.TryParse(input, out result);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExitCurrent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnSearchEm_Click(object sender, EventArgs e)
        {
            cmbEmployeeID.Visible = true;
            cmbEmployeeID.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeID FROM EmpDetails";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmployeeID.Items.Add(reader["EmployeeID"].ToString());
                }
                connection.Close();
            }
        }

        private void btnClearEm_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            SetDefaultState();
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void btnDel_Click(object sender, EventArgs e)

        {
            try
            {
                string employeeID = cmbEmployeeID.SelectedItem.ToString();
                DialogResult resDel = MessageBox.Show("Do you want to delete Employee ID : " + employeeID + " ?", "Confirm to delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resDel == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Start a local transaction
                        SqlTransaction transaction;

                        connection.Open();
                        transaction = connection.BeginTransaction();

                        try
                        {
                            // Create the command to delete from Leave
                            string queryLeaves = "DELETE FROM Leave WHERE EmployeeID = '" + employeeID + "'";
                            SqlCommand commandLeaves = new SqlCommand(queryLeaves, connection, transaction);

                            // Execute the command to delete from Leave
                            commandLeaves.ExecuteNonQuery();
                            // Create the command to delete from Salary
                            string querySalary = "DELETE FROM Salary WHERE EmployeeID = '" + employeeID + "'";
                            SqlCommand commandSalary = new SqlCommand(querySalary, connection, transaction);

                            // Execute the command to delete from Salary
                            commandSalary.ExecuteNonQuery();

                            // Create the command to delete from EmpDetails
                            string queryEmpDetails = "DELETE FROM EmpDetails WHERE EmployeeID = '" + employeeID + "'";
                            SqlCommand commandEmpDetails = new SqlCommand(queryEmpDetails, connection, transaction);

                            // Execute the command to delete from EmpDetails
                            int resultEmpDetails = commandEmpDetails.ExecuteNonQuery();

                            // Check if deletion was successful
                            if (resultEmpDetails > 0)
                            {
                                // Commit the transaction
                                transaction.Commit();
                                MessageBox.Show("Employee ID : " + employeeID + " successfully deleted !", "Deleted !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clear(); // Assuming this method clears the form fields and resets the state
                            }
                            else
                            {
                                // Rollback the transaction in case of failure
                                transaction.Rollback();
                                MessageBox.Show("Error deleting selected employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of exception
                            transaction.Rollback();
                            MessageBox.Show("Error while Delete..." + Environment.NewLine + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + DelErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string gen = "";
                if (rbMale.Checked == true)
                    gen = "Male";
                else if (rbFemale.Checked == true)
                    gen = "Female";
                else
                {
                    MessageBox.Show("Please select a gender !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate inputs
                if (!AreAllFieldsFilled())
                {
                    MessageBox.Show("Please fill in all fields before updating !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCivilStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select civil status before updating !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidateInputs())
                {
                    MessageBox.Show("Please ensure NIC, contact number, and salary fields are in correct format !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construct SQL query
                string query = $@"
            UPDATE EmpDetails SET 
            EmployeeName = '{txtEmployeeName.Text}', 
            NIC = '{txtNIC.Text}', 
            ContactNumber = '{txtContactNumber.Text}', 
            Address = '{txtAddress.Text}', 
            DateOfBirth = '{dtpDateOfBirth.Value.ToString("yyyy-MM-dd")}', 
            Gender = '{gen}', 
            CivilStatus = '{cmbCivilStatus.SelectedItem.ToString()}', 
            MonthlySalary = {decimal.Parse(txtMonthlySalary.Text)}, 
            OvertimeRate = {decimal.Parse(txtOvertimeRate.Text)}, 
            Allowance = {decimal.Parse(txtAllowance.Text)}
            WHERE EmployeeID = '{lblEmployeeID.Text}'";

                // Execute SQL query
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    // Check and show result
                    if (result > 0)
                    {
                        MessageBox.Show($"Employee details updated successfully for Employee ID : {lblEmployeeID.Text} !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields();
                        SetDefaultState();
                        rbMale.Checked = false;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show($"Error updating employee details for Employee ID : {lblEmployeeID.Text} !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            try
            {
                string gen = "";
                if (rbMale.Checked == true) { gen = "Male"; }
                else if (rbFemale.Checked == true) { gen = "Female"; }

                if (AreAllFieldsFilled() && IsGenderSelected() && (cmbCivilStatus.SelectedIndex > 0))
                {
                    if (IsNicValid(txtNIC.Text) && IsContactNumberValid(txtContactNumber.Text))
                    {
                        decimal monthlySalary, overtimeRate, allowance;
                        if (decimal.TryParse(txtMonthlySalary.Text, out monthlySalary) &&
                            decimal.TryParse(txtOvertimeRate.Text, out overtimeRate) &&
                            decimal.TryParse(txtAllowance.Text, out allowance))
                        {
                            string query = "INSERT INTO EmpDetails (EmployeeID, EmployeeName, NIC, ContactNumber, Address, DateOfBirth, Gender, CivilStatus, MonthlySalary, OvertimeRate, Allowance) VALUES ('"
                                + lblEmployeeID.Text + "', '"
                                + txtEmployeeName.Text + "', '"
                                + txtNIC.Text + "', '"
                                + txtContactNumber.Text + "', '"
                                + txtAddress.Text + "', '"
                                + dtpDateOfBirth.Text + "', '"
                                + gen + "', '"
                                + cmbCivilStatus.SelectedItem.ToString() + "', "
                                + monthlySalary + ", "
                                + overtimeRate + ", "
                                + allowance + ")";

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                SqlCommand command = new SqlCommand(query, connection);
                                connection.Open();
                                command.ExecuteNonQuery();
                                UpdateNextEmployeeID(); 
                                string currentEmployeeID = lblEmployeeID.Text; 
                                LoadNextEmployeeID(); 
                                connection.Close();

                                MessageBox.Show("Employee ID: " + currentEmployeeID + " successfully saved !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFormFields();
                                SetDefaultState();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Monthly salary, overtime rate, and allowance must be in decimal format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure NIC and contact number are valid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception SaveErr)
            {
                MessageBox.Show("Error while save..." + Environment.NewLine + SaveErr);
            }
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            LoadNextEmployeeID();
            SetDefaultState();
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


      
    

