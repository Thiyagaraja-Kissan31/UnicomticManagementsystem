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
    public partial class Exam_Management : Form
    {
        private ExamController examcontroller = new ExamController();
        public Exam_Management()
        {
            InitializeComponent();
            LoadExams();
        }

        private void LoadExams()
        {
            examdataGridView1.DataSource = null;
            examdataGridView1.DataSource = examcontroller.GetAllExams();
            examdataGridView1.ClearSelection();
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void Exam_Management_Load(object sender, EventArgs e)
        {
            var subjects = SubjectController.GetAllSubject();
            subjectextBox2.DataSource = subjects;
            subjectextBox2.DisplayMember = "SubjectName";
            subjectextBox2.ValueMember = "Id";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (examdataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(examdataGridView1.SelectedRows[0].Cells["Id"].Value);
                var Exams = new Exam
                {
                    Id = id,
                    SubjectName = subjectextBox2.Text.Trim(),
                    Date = dateTextBox1.Text,
                    Time = timeTextBox2.Text,
                };
                examcontroller.UpdateExam(Exams);
                LoadExams();
                
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var Exams = new Exam
            {
                SubjectName = subjectextBox2.Text.Trim(),
                Date = dateTextBox1.Text,
                Time = timeTextBox2.Text,
            };
            examcontroller.AddExam(Exams);
            LoadExams();
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (examdataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(examdataGridView1.SelectedRows[0].Cells["Id"].Value);
                examcontroller.DeleteExam(id);
                LoadExams();
                
            }
        }

        private void examdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (examdataGridView1.SelectedRows.Count > 0)
            {
                subjectextBox2.Text = examdataGridView1.SelectedRows[0].Cells["SubjectName"].Value.ToString();
            }
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void tittle_Click(object sender, EventArgs e)
        {

        }

        private void subjectname_Click(object sender, EventArgs e)
        {

        }
    }
}
