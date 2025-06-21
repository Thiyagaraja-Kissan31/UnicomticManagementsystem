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
    public partial class Student_Management : Form
    {
        private StudentController studentController = new StudentController();

        public Student_Management()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            studentdetails.DataSource = null;
            studentdetails.DataSource = studentController.GetAllStudents();
            studentdetails.ClearSelection();
        }

        private void Student_Management_Load(object sender, EventArgs e)
        {
            var subjects = SubjectController.GetAllSubject();
            subjectcombobox.DataSource = subjects;
            subjectcombobox.DisplayMember = "SubjectName"; 
            subjectcombobox.ValueMember = "Id";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var student = new Students
            {
                StudentName = name.Text,
                Address = addresstextbox.Text,
                Gender = gendercombobox.Text,
                Date_of_Birth = dateofbirthTextBox1.Text,
                SubjectName = subjectcombobox.Text,
                PhoneNumber = phonenumberTextBox2.Text,
                EmailId = emailtextbox.Text,

            };
            studentController.AddStudent(student);
            LoadStudents();
            MessageBox.Show("SuccesFully Add Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateofbirthTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void subjectcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gendercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void subject_Click(object sender, EventArgs e)
        {

        }

        private void phonenumber_Click(object sender, EventArgs e)
        {

        }

        private void dateofbirth_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void studentname_Click(object sender, EventArgs e)
        {

        }

        private void studentdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentdetails.SelectedRows.Count > 0)
            {
                name.Text = studentdetails.SelectedRows[0].Cells["StudentID"].Value.ToString();
            }
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (studentdetails.SelectedRows.Count > 0)
            {
                int StudentID = Convert.ToInt32(studentdetails.SelectedRows[0].Cells["StudentID"].Value);
                studentController.DeleteStudent(StudentID);
                LoadStudents();
                MessageBox.Show("Delete Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (studentdetails.SelectedRows.Count > 0)
            {
                int StudentID = Convert.ToInt32(studentdetails.SelectedRows[0].Cells["StudentID"].Value);
                var student = new Students
                {

                    StudentName = name.Text,
                    Address = addresstextbox.Text,
                    Gender = gendercombobox.Text,
                    Date_of_Birth = dateofbirthTextBox1.Text,
                    SubjectName = subjectcombobox.Text,
                    PhoneNumber = phonenumberTextBox2.Text,
                    EmailId = emailtextbox.Text,
                };
                studentController.UpdateStudent(student);
                LoadStudents();
                MessageBox.Show("Update Add Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
