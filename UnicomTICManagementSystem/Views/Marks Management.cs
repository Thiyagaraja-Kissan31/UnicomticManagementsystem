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
    public partial class Marks_Management : Form
    {
        private MarkController markcontroller = new MarkController();
        private Form previousForm;
        private string selectedRole;
        public Marks_Management()
        {
            InitializeComponent();
            LoadMarks();
        }
        public Marks_Management(Form prevForm, string role)
        {
            InitializeComponent();
            previousForm = prevForm;
            selectedRole = role;
            LoadMarks();
        }
        private void LoadMarks()
        {
            marksdataGridView1.DataSource = null;
            marksdataGridView1.DataSource = markcontroller.GetAllMarks();
            marksdataGridView1.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void Marks_Management_Load(object sender, EventArgs e)
        {
            var subjects = SubjectController.GetAllSubject();
            subjectname1.DataSource = subjects;
            subjectname1.DisplayMember = "SubjectName";
            subjectname1.ValueMember = "Id";

            var studentController = new StudentController();
            var students =studentController.GetAllStudents();
            studentname1.DataSource = students;
            studentname1.DisplayMember = "StudentName";
            studentname1.ValueMember = "StudentID"; 
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var Marks = new Mark
            {
                StudentName = studentname1.Text,
                SubjectName = subjectname1.Text,
                Marks = marks1.Text,
                Date = dateTextBox1.Text,
            };
            markcontroller.AddMark(Marks);
            LoadMarks();
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (marksdataGridView1.SelectedRows.Count > 0)
            {
                int MarksID = Convert.ToInt32(marksdataGridView1.SelectedRows[0].Cells["MarksID"].Value);
                var Marks = new Mark
                {
                    MarksID = MarksID,
                    StudentName = studentname1.Text,
                    SubjectName = subjectname1.Text,
                    Marks = marks1.Text.Trim(),
                    Date = dateTextBox1.Text,
                };
                markcontroller.UpdateMark(Marks);
                LoadMarks();
                
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (marksdataGridView1.SelectedRows.Count > 0)
            {
                int MarksID = Convert.ToInt32(marksdataGridView1.SelectedRows[0].Cells["MarksId"].Value);
                markcontroller.DeleteMark(MarksID);
                LoadMarks();
                
            }
        }

        private void marksdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (marksdataGridView1.SelectedRows.Count > 0)
            {
                marksdataGridView1.Text = marksdataGridView1.SelectedRows[0].Cells["MarksID"].Value.ToString();
            }
        }
    }
}
