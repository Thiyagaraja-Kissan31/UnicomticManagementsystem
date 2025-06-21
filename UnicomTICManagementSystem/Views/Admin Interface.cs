using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }

        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }

        private void studentbtn_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Student_Management studentmanagement = new Student_Management();
            studentmanagement.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marks_Management marks_Management = new Marks_Management();
            marks_Management.ShowDialog();
        }

        private void timetablebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetable_Management timetable_Management = new Timetable_Management();
            timetable_Management.ShowDialog();
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Management staff_Management = new Staff_Management();
            staff_Management.ShowDialog();
        }

        private void lecturebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer_Management lecturer_Management = new Lecturer_Management();
            lecturer_Management.ShowDialog();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam_Management exam_Management = new Exam_Management();
            exam_Management.ShowDialog();
        }

        private void subjectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subject_Management subject_Management = new Subject_Management();   
            subject_Management.ShowDialog();
        }

        private void attendance_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Attendance_Management attendance_Management = new Attendance_Management();  
            attendance_Management.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainlogin mainlogin = new Mainlogin();  
            mainlogin.ShowDialog();
        }
    }
}
