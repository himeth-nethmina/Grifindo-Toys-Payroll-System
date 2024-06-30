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
    public partial class LeaveForm : Form
    {
        private IFormatProvider leavingDays;

        public LeaveForm()
        {
            InitializeComponent();
            LoadEmployeeIDs();
            
        }

        // This method loads employee IDs into the combo box from the database
        private void LoadEmployeeIDs()
        {
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT EmployeeID FROM EmpDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmployeeID.Items.Add(reader["EmployeeID"].ToString());
                }
            }
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex > 0)  
            {
                string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT EmployeeName FROM EmpDetails WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", cmbEmployeeID.SelectedItem.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblEmployeeName.Text = reader["EmployeeName"].ToString();
                    }
                }
            }
            else
            {
                lblEmployeeName.Text = ""; 
            }
        }

   


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Validate input fields
            if (cmbEmployeeID.SelectedItem == null ||
                string.IsNullOrWhiteSpace(lblEmployeeName.Text) ||
                string.IsNullOrWhiteSpace(txtReason.Text) ||
                string.IsNullOrWhiteSpace(txtLeavingDays.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int leavingDays;
            if (!int.TryParse(txtLeavingDays.Text, out leavingDays))
            {
                MessageBox.Show("Leaving Days must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime todayDate = dtpTodayDate.Value.Date;
            DateTime leaveDate = dtpLeaveDate.Value.Date;

            // Check if the selected dates are valid
            if (leaveDate <= todayDate)
            {
                MessageBox.Show("Please select a leave date that is after today's date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO Leave (EmployeeID, Reason, TodayDate, LeaveDate, LeavingDays)
                         VALUES (@EmployeeID, @Reason, @TodayDate, @LeaveDate, @LeavingDays)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployeeID", cmbEmployeeID.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
                cmd.Parameters.AddWithValue("@TodayDate", todayDate);
                cmd.Parameters.AddWithValue("@LeaveDate", leaveDate);
                cmd.Parameters.AddWithValue("@LeavingDays", leavingDays);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Leave record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear form details
                    cmbEmployeeID.SelectedItem = null;
                    lblEmployeeName.Text = "";
                    txtReason.Text = "";
                    txtLeavingDays.Text = "";
                    dtpTodayDate.Value = DateTime.Today;  // Reset to today's date
                    dtpLeaveDate.Value = DateTime.Today;  // Reset to today's date
                    cmbEmployeeID.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error saving leave record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewLeaves viewLeavesForm = new ViewLeaves();


            viewLeavesForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}