using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class MainLoginForm : Form
    {
        public string ManagementName = "Unicomtic";
        public string ManagementPassword = "Unicom@123";

        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void MainLoginForm_Load(object sender, EventArgs e)
        {

        }

       
        private void Admin_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {

            string adminNameInput = ManagementName.Text.Trim();
            string adminPasswordInput = ManagementPassword.Text;

            if (adminNameInput == ManagementName && adminPasswordInput == ManagementPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
                MainLoginForm mainForm = new MainLoginForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tittle_Click(object sender, EventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void Management_Name(object sender, EventArgs e)
        {

        }
    }
}
