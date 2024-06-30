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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            PopulateUserComboBox();
            txtConfirmPassword.PasswordChar = '*';
        }
        private void PopulateUserComboBox()
        {
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Username FROM Admins";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDeleteUser.Items.Add(reader["Username"].ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (cmbUserType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRealName.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the passwords match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Admins WHERE Username = @Username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Username", txtUserName.Text);

                int userCount = (int)checkCmd.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save the user details to the database
                string insertQuery = @"INSERT INTO Admins (Username, Password, Realname, UserType)
                         VALUES (@Username, @Password, @Realname, @UserType)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@UserType", cmbUserType.SelectedItem.ToString());
                insertCmd.Parameters.AddWithValue("@Realname", txtRealName.Text);
                insertCmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                insertCmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                int result = insertCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear form details after successful save
                    cmbUserType.SelectedItem = null;
                    txtRealName.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtUserName.Text = "";
                    cmbUserType.SelectedIndex = 0;
                    RefreshUserComboBox();
                }
                else
                {
                    MessageBox.Show("Error saving user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDeleteUser.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usernameToDelete = cmbDeleteUser.SelectedItem.ToString();

            string connectionString = "Data Source=LAPTOP-LHOUG7S2;Initial Catalog=GrifindoToys;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Admins WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", usernameToDelete);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Remove the deleted user from the ComboBox
                    cmbDeleteUser.Items.Remove(usernameToDelete);
                }
                else
                {
                    MessageBox.Show("Error deleting user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshUserComboBox();
        }
        private void RefreshUserComboBox()
        {
            cmbDeleteUser.Items.Clear();
            PopulateUserComboBox();
        }
    }
}
