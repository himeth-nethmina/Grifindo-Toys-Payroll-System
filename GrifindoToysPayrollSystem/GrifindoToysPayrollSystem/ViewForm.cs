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
    public partial class ViewLeaves : Form
    {
        public ViewLeaves()
        {
            InitializeComponent();
            LoadEmployeeIDs();

        }
        //Load employee IDs from the database
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

        private void ViewLeaves_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbEmployeeID.SelectedIndex >= 0)
                {
                    string employeeID = cmbEmployeeID.SelectedItem.ToString();
                    DisplayEmployeeName(employeeID);
                    DisplayLeaveDetails(employeeID);
                }
            }
        }
        // Display the selected employee's name
        private void DisplayEmployeeName(string employeeID)
        {
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT EmployeeName From EmpDetails WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblEmployeeName.Text = reader["EmployeeName"].ToString();
                }
            }
        }
        // Display the selected employee's leave details
        private void DisplayLeaveDetails(string employeeID)
        {
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT LeaveID, TodayDate, LeaveDate, LeavingDays, Reason 
                             FROM Leave 
                             WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable leaveDetailsTable = new DataTable();
                adapter.Fill(leaveDetailsTable);
                dgvLeaveDetails.DataSource = leaveDetailsTable;
            }
        }

        private void dgvLeaveDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
