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
            ViewTimetable ViewTimetable = new ViewTimetable(this, "NewStafff");
            ViewTimetable.ShowDialog();
        }

        private void attendancetbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIewAttendance attendance = new VIewAttendance(this, "NewStafff");
            attendance.ShowDialog();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam_Management exam_management = new Exam_Management(this, "NewStafff");
            exam_management.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marks_Management marks_management = new Marks_Management(this, "NewStafff");
            marks_management.ShowDialog();
        }
    }
}
