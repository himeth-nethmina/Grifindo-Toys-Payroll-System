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
    public partial class AllEmployeesSalaryReport : Form
    {
        private string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
        private bool isRangeUpdating = false;
        public AllEmployeesSalaryReport()
        {
            InitializeComponent();
        }
        
        // Method to display salaries for a specific month
        private void DisplaySalaries(DateTime startDate, DateTime endDate, Label basePayLabel, Label noPayLabel, Label grossPayLabel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT ISNULL(SUM(BasePay), 0) AS TotalBasePay, ISNULL(SUM(NoPay), 0) AS TotalNoPay, ISNULL(SUM(GrossPay), 0) AS TotalGrossPay
                                 FROM Salary
                                 WHERE YEAR(BeginDate) = @Year AND MONTH(BeginDate) = @Month";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", startDate.Year);
                command.Parameters.AddWithValue("@Month", startDate.Month);

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

                        basePayLabel.Text = totalBasePay.ToString("0.00");
                        noPayLabel.Text = totalNoPay.ToString("0.00");
                        grossPayLabel.Text = totalGrossPay.ToString("0.00");
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













        // Method to display salaries in a range of months
        private void DisplaySalariesInRange(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT ISNULL(SUM(BasePay), 0) AS TotalBasePay, ISNULL(SUM(NoPay), 0) AS TotalNoPay, ISNULL(SUM(GrossPay), 0) AS TotalGrossPay
                         FROM Salary
                         WHERE YEAR(BeginDate) * 100 + MONTH(BeginDate) >= @StartYearMonth 
                         AND YEAR(EndDate) * 100 + MONTH(EndDate) <= @EndYearMonth";
                SqlCommand command = new SqlCommand(query, connection);
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

                        lblSelectedRangeBasePay.Text = totalBasePay.ToString("0.00");
                        lblSelectedRangeNoPay.Text = totalNoPay.ToString("0.00");
                        lblSelectedRangeGrossPay.Text = totalGrossPay.ToString("0.00");
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







        // Method to clear the labels
        private void ClearLabels()
        {
            lblFirstMonthBasePay.Text = "0.00";
            lblFirstMonthNoPay.Text = "0.00";
            lblFirstMonthGrossPay.Text = "0.00";

            lblSecondMonthBasePay.Text = "0.00";
            lblSecondMonthNoPay.Text = "0.00";
            lblSecondMonthGrossPay.Text = "0.00";

            lblSelectedRangeBasePay.Text = "0.00";
            lblSelectedRangeNoPay.Text = "0.00";
            lblSelectedRangeGrossPay.Text = "0.00";
        }







        private void AllEmployeesSalaryReport_Load(object sender, EventArgs e)
        {

        }

        private void lblSecondMonthNoPay_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCurrent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnSingleMonth1_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSingleMonth1.Value;
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            DisplaySalaries(startDate, endDate, lblFirstMonthBasePay, lblFirstMonthNoPay, lblFirstMonthGrossPay);
        }

        private void btnSingleMonth2_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSingleMonth2.Value;
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            DisplaySalaries(startDate, endDate, lblSecondMonthBasePay, lblSecondMonthNoPay, lblSecondMonthGrossPay);
        }

        private void btnRange_Click_Click_1(object sender, EventArgs e)
        {
            if (!isRangeUpdating)
            {
                isRangeUpdating = true;
                DateTime startDate = dtpRangeStart.Value;
                DateTime endDate = dtpRangeEnd.Value;
                DisplaySalariesInRange(startDate, endDate);
                isRangeUpdating = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}