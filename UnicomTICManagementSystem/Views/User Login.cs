using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class User_Login : Form
    {
        // Lecturer Login Details========================
        internal string LecturerUsername = "Lecturer";
        internal string LecturerPassword = "Lecturer@123";
        //Staff Login Details==========================
        internal string StaffUsername = "NewStaff";
        internal string StaffPassword = "NewStaff@123";
        // Student Login Details==========================
        internal string StudentUsername = "Student";
        internal string StudentPassword = "Student@123";
        public User_Login()
        {
            InitializeComponent();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            StaffForm staff = new StaffForm();
            Student student = new Student();
            password.UseSystemPasswordChar = true;
        }

        private void cancelbtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainlogin mainlogin = new Mainlogin();
            mainlogin.Show();
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

            if (selectedRole == "Lecturer")
            {
                if (enteredUsername == LecturerUsername && enteredPassword == LecturerPassword)
                {
                    MessageBox.Show("Lecturer login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lectrer lecturerForm = new Lectrer();
                    this.Hide();
                    lecturerForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "NewStaff")
            {
                if (enteredUsername == StaffUsername && enteredPassword == StaffPassword)
                {
                    MessageBox.Show("NewStaff login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaffForm staff = new StaffForm();
                    this.Hide();
                    staff.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "Student")
            {
                if (enteredUsername == StudentUsername && enteredPassword == StudentPassword)
                {
                    MessageBox.Show("Student login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Student student = new Student();
                    this.Hide();
                    student.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showpasswordbtn_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            password.Show();
        }
    }
}
