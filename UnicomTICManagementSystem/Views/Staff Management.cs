using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Staff_Management : Form
    {
        private StaffController staffcontroller = new StaffController();

        public Staff_Management()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            staffdataGridView1.DataSource = null;
            staffdataGridView1.DataSource = staffcontroller.GetAllStaff();
            staffdataGridView1.ClearSelection();
        }
        private void Staff_Management_Load(object sender, EventArgs e)
        {
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var Staff = new NewStaff
            {
                StaffName = name.Text,    
                Address = addresstextbox.Text,
                Gender = gendercombobox.Text,
                Dateofbirth = dateofbirthTextBox1.Text,
                MobileNumber = mobilenum.Text,
                EmailId = emailtextbox.Text,

            };
            StaffController.AddStaff(Staff);
            MessageBox.Show("SuccesFully Add NewStaff!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mo(object sender, EventArgs e)
        {
        }

        private void staffdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (staffdataGridView1.SelectedRows.Count > 0)
            {
                name.Text = staffdataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            }
        }

        private void dateofbirthTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            if (staffdataGridView1.SelectedRows.Count > 0)
            {
                int StaffID = Convert.ToInt32(staffdataGridView1.SelectedRows[0].Cells["StaffID"].Value);
                staffcontroller.DeleteStaff(StaffID);
                LoadStaff();
                MessageBox.Show("Delete Staff!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
