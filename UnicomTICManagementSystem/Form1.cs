using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    public partial class Adminloginform : Form
    {
        public string AdminName = "Unicomtic";
        public string AdminPassword = "Unicom@123";

        public Adminloginform()
        {
            InitializeComponent();
        }

        private void Admin_Name_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void Admin_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {
            string adminNameInput = Admin_Name.Text.Trim();
            string adminPasswordInput = Admin_password.Text;

            if (adminNameInput == AdminName && adminPasswordInput == AdminPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void Tittle_Click(object sender, EventArgs e)
        {
            // Title label click logic if needed
        }
    }
}
