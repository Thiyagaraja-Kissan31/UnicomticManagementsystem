using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Lecturer_Management : Form
    {
        private LecturerController lecturerController = new LecturerController();
        public Lecturer_Management()
        {
            InitializeComponent();
            LoadLecturer();
        }
        private void LoadLecturer()
        {
            lecturerdataGridView.DataSource = null;
            lecturerdataGridView.DataSource = lecturerController.GetAllLecturers();
            lecturerdataGridView.ClearSelection();
        }

        private void Lecturer_Management_Load(object sender, EventArgs e)
        {
            var subjects = SubjectController.GetAllSubject();
            subjectcombobox.DataSource = subjects;
            subjectcombobox.DisplayMember = "SubjectName";
            subjectcombobox.ValueMember = "Id";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface(); 
            adminInterface.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var lecturer = new Lecturer
            {
                LecturerName = name.Text,
                SubjectName = subjectcombobox.Text,
                Address = addresstextbox.Text,
                Gender = gendercombobox.Text,
                Dateofbirth = dateofbirthTextBox1.Text,
                MobileNumber = mobilenum.Text,
                Email = emailtextbox.Text,

            };
            lecturerController.AddLecturer(lecturer);
            MessageBox.Show("SuccesFully Add Lecturer!", "Success" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }


        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (lecturerdataGridView.SelectedRows.Count > 0)
            {
                int LectureID = Convert.ToInt32(lecturerdataGridView.SelectedRows[0].Cells["LectureID"].Value);
                lecturerController.DeleteLecturer(LectureID);
                LoadLecturer();
                MessageBox.Show("Delete Student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void lecturerdataGridView_click(object sender, DataGridViewCellEventArgs e)
        {
            if (lecturerdataGridView.SelectedRows.Count > 0)
            {
                name.Text = lecturerdataGridView.SelectedRows[0].Cells["LectureID"].Value.ToString();
            }
        }
    }
}
