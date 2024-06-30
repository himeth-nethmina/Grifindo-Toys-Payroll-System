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
    public partial class SettingsForm : Form
    {
        private const string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
        private DateTime initialBeginDate;
        private DateTime initialEndDate;
        private int initialLeavesPerYear;
        private decimal initialTaxRate;
        private string initialDateRangeForSalaryCycle;

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }
        // Method to load settings from the database
        private void LoadSettings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeesSettings", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        initialBeginDate = (DateTime)reader["SalaryCycleBeginDate"];
                        initialEndDate = (DateTime)reader["SalaryCycleEndDate"];
                        initialLeavesPerYear = (int)reader["LeavesPerYear"];
                        initialTaxRate = (decimal)reader["GovernmentTaxRate"];
                        initialDateRangeForSalaryCycle = reader["DateRangeForSalaryCycle"].ToString();

                        dtpBeginDate.Value = initialBeginDate;
                        dtpEndDate.Value = initialEndDate;
                        txtNumOfLeaves.Text = initialLeavesPerYear.ToString();
                        txtTaxRate.Text = initialTaxRate.ToString();
                        txtDateRangeForSalaryCycle.Text = initialDateRangeForSalaryCycle;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCurrent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                int leaves;
                if (!int.TryParse(txtNumOfLeaves.Text, out leaves) || leaves < 0)
                {
                    MessageBox.Show("Please enter a valid number for Leaves Per Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal taxRate;
                if (!decimal.TryParse(txtTaxRate.Text, out taxRate) || taxRate < 0)
                {
                    MessageBox.Show("Please enter a valid number for Tax Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Settings SET SalaryCycleBeginDate=@BeginDate, SalaryCycleEndDate=@EndDate, LeavesPerYear=@Leaves, GovernmentTaxRate=@TaxRate, DateRangeForSalaryCycle=@DateRangeForSalaryCycle", connection);
                    cmd.Parameters.AddWithValue("@BeginDate", dtpBeginDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    cmd.Parameters.AddWithValue("@Leaves", leaves);
                    cmd.Parameters.AddWithValue("@TaxRate", taxRate);
                    cmd.Parameters.AddWithValue("@DateRangeForSalaryCycle", txtDateRangeForSalaryCycle.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialBeginDate = dtpBeginDate.Value;
                        initialEndDate = dtpEndDate.Value;
                        initialLeavesPerYear = leaves;
                        initialTaxRate = taxRate;
                        initialDateRangeForSalaryCycle = txtDateRangeForSalaryCycle.Text;
                    }
                    else
                    {
                        MessageBox.Show("No settings were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
