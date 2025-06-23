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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void timetalebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTimetable ViewTimetable = new ViewTimetable(this, "Student");
            ViewTimetable.ShowDialog();
        }

        private void subjectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSubjects subject = new ViewSubjects(this, "Student");
            subject.ShowDialog();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewExams viewexams = new ViewExams(this, "Student");
            viewexams.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMarks marks = new ViewMarks(this, "Student");
            marks.ShowDialog();
        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            VIewAttendance viewattendance = new VIewAttendance(this, "Student");
            this.Hide();
            viewattendance.Show();
        }
    }
}
