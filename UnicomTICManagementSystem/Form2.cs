using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem
{
    public partial class Userloginform : Form
    {
        public Userloginform()
        {
            InitializeComponent();
        }

        private void User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_password_TextChanged(object sender, EventArgs e)
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

        private void Userloginform_Load(object sender, EventArgs e)
        {
            UsersCombobox.Items.Add("Lecturers");
            UsersCombobox.Items.Add("Staff");
            UsersCombobox.Items.Add("Students");
        }
    }
}
