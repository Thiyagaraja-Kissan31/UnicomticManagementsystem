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

namespace UnicomTICManagementSystem.Views
{
    public partial class ViewExams : Form
    {
        private ExamController examview = new ExamController();
        private Form previousForm;
        private string selectedRole;
        public ViewExams()
        {
            InitializeComponent();
            LoadExam(GetAllExams());
        }
        public ViewExams(Form prevForm, string role)
        {
            InitializeComponent();
            previousForm = prevForm;
            selectedRole = role;
            LoadExam(GetAllExams());
        }
        private ExamController GetAllExams()
        {
            return examview;
        }

        private void LoadExam(ExamController examview)
        {
            var examData = examview.GetAllExams();

            viewexamdata2.DataSource = examData;
            viewexamdata2.ReadOnly = true;
            viewexamdata2.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void ViewExams_Load(object sender, EventArgs e)
        {

        }

        private void viewexamdata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
