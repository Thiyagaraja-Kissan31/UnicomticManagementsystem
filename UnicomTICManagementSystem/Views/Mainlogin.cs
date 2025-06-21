using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class Mainlogin : Form
    {
        // Admin Loin Details========================
        internal string adminUsername = "Admin";
        internal string adminPassword = "Admin@123";
        //User Login Details==========================
        internal string userUsername = "User";
        internal string userPassword = "User@123";

        public Mainlogin()
        {
            InitializeComponent();
        }

        private void cancelbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mainlogin_Load(object sender, EventArgs e)
        {
           Admin_Interface adminInterface = new Admin_Interface();
           User_Login userLogin = new User_Login();
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {
            string selectedRole = rolecomboBox1.SelectedItem?.ToString();
            string enteredUsername = username.Text.Trim();
            string enteredPassword = password.Text.Trim();

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRole == "Admin")
            {
                if (enteredUsername == adminUsername && enteredPassword == adminPassword)
                {
                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Interface adminInterface = new Admin_Interface();
                    this.Hide();
                    adminInterface.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "User")
            {
                if (enteredUsername == userUsername && enteredPassword == userPassword)
                {
                    MessageBox.Show("User login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User_Login userLogin = new User_Login();
                    this.Hide();
                    userLogin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
