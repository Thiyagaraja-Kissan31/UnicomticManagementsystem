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
    public partial class AdminMainForm : Form
    {
        private StudentController _controller = new StudentController();
        private int selectedStudentId = -1;
        public AdminMainForm()
        {
            InitializeComponent();
            LoadStudent();
        }
        private void LoadStudent()
        {
            StudentdataGridView1.DataSource = _controller.GetAllStudent();
            StudentdataGridView1.ClearSelection();
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            SexcomboBox.Items.Clear();
            SexcomboBox.Items.Add("Male");
            SexcomboBox.Items.Add("Female");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void SexcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = SexcomboBox.SelectedItem.ToString();
            MessageBox.Show("You selected: " + selectedItem);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != -1)
            {
                Student student = new Student
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Sex = SexcomboBox.SelectedItem?.ToString()
                };
                _controller.AddStudent(student);
                LoadStudent();
                ClearInputs();
            }
        }
             private void ClearInputs()
                {
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    SexcomboBox.SelectedIndex = -1;
                    selectedStudentId = -1;
                }


        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != -1)
            {
                Student student = new Student
                {
                    Id = selectedStudentId,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Sex = SexcomboBox.SelectedItem?.ToString()
                };
                _controller.UpdateStudent(student);
                LoadStudent();
                ClearInputs();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != -1)
            {
                _controller.DeleteStudent(selectedStudentId);
                LoadStudent();
                ClearInputs();
            }
        }

        private void StudentdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentdataGridView1.SelectedRows.Count > 0)
            {
                var row = StudentdataGridView1.SelectedRows[0];
                var student = row.DataBoundItem as Student;
                if (student != null)
                {
                    selectedStudentId = student.Id;
                    txtName.Text = student.Name;
                    txtPhone.Text = student.Phone;
                    txtAddress.Text = student.Address;
                    SexcomboBox.SelectedItem = student.Sex;
                }
            }
        }
    }
}
