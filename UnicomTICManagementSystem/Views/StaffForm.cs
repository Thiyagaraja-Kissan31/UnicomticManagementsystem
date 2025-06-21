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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }

        private void timetalebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTimetable ViewTimetable = new ViewTimetable();
            ViewTimetable.ShowDialog();
        }

        private void attendancetbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIewAttendance attendance = new VIewAttendance();
            attendance.ShowDialog();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewExams viewexams = new ViewExams();
            viewexams.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMarks marks = new ViewMarks();
            marks.ShowDialog();
        }
    }
}
