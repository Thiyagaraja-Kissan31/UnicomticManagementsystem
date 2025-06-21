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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            UsersCombobox.Items.Add("Lecturers");
            UsersCombobox.Items.Add("Staff");
            UsersCombobox.Items.Add("Students");
        }

        private void User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {

        }

        private void UsersCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = UsersCombobox.SelectedItem.ToString();
            MessageBox.Show("You selected: " + selectedItem);
        }
    }
}
