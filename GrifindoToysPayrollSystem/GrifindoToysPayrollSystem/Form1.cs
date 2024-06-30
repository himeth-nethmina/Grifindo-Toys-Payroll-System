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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); // Initialize the components of the form
            txtPassword.PasswordChar = '*'; // Set the password character to '*' for the password textbox
            PopulateUserTypeComboBox();

        }

        private void PopulateUserTypeComboBox()
        {
            // Add user type options to the combo box
            cmbUserType.Items.Add("-Select User Type-");
            cmbUserType.Items.Add("System Administrator");
            cmbUserType.Items.Add("System User");
            cmbUserType.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void btnSav_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Check if all fields are filled and a user type is selected
            if (cmbUserType.SelectedIndex == 0 || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields and select a user type !");
                return;
            }
            // SQL query to check the username and password

            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Realname, UserType FROM Admins WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // If a matching record is found
                    {
                        string realName = reader["Realname"].ToString();
                        string userType = reader["UserType"].ToString();
                        // Check if the user type matches the selected user type
                        if (userType == cmbUserType.SelectedItem.ToString())
                        {
                            MainForm mainForm = new MainForm(realName, userType);
                            mainForm.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("User type does not match.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect.");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application if clicked Yes
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                cmbUserType.SelectedIndex = 0; // Reset the combo box to the default selection
            }
        }
    }
}



    
    
    

