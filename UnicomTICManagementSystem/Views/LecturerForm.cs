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
    public partial class Lectrer : Form
    {
        public Lectrer()
        {
            InitializeComponent();
        }

        private void timetalebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTimetable ViewTimetable = new ViewTimetable(this, "Lecturer");
            ViewTimetable.ShowDialog();
            
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam_Management exam_management = new Exam_Management(this, "Lecturer");
            exam_management.ShowDialog();
        }

        private void subjectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSubjects subject = new ViewSubjects(this, "Lecturer");
            subject.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marks_Management marks_management = new Marks_Management(this, "Lecturer");
            marks_management.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }

    }
}
