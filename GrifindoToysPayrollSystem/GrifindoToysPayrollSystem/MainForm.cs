using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrifindoToysPayrollSystem
{
    public partial class MainForm : Form
    {
        private string adminsRealName; // Variable to store the admin's real name
        private string userType; // Variable to store the user type

        public MainForm(string adminsRealName, string userType)
        {
            InitializeComponent(); // Initialize the components of the form
            this.adminsRealName = adminsRealName; // Assign the admin's real name
            this.userType = userType; // Assign the user type
            lblWelcome.Text = $"Welcome to the Grifindo Toys Payroll System, {adminsRealName}"; // Set the welcome label text
            timer1.Start(); // Start the timer to update the date and time

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F"); // Update the label with the current date and time

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private EmployeeForm previousForm; 



        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
           

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            salaryForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userType == "System Administrator")
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Only System Administrators can change settings !");
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void button5_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (userType == "System Administrator")
            {
                AddUser AddUserForm = new AddUser();
                AddUserForm.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Only System Administrators can assign system users !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       
        private void btnemployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            salaryForm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (userType == "System Administrator")
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Only System Administrators can change settings !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
