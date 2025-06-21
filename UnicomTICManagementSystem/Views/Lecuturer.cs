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
    public partial class Lecuturer : Form
    {
        public Lecuturer()
        {
            InitializeComponent();
        }

        private void timetalebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetable_Management timetable = new Timetable_Management();
            timetable.ShowDialog();
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam_Management exam = new Exam_Management();
            exam.ShowDialog();
        }

        private void subjectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subject_Management subject = new Subject_Management();
            subject.ShowDialog();
        }

        private void marksbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marks_Management marks = new Marks_Management();
            marks.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }

        private void Lecuturer_Load(object sender, EventArgs e)
        {

        }
    }
}
