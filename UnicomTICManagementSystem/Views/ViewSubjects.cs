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
    public partial class ViewSubjects : Form
    {
        private SubjectController subjectview = new SubjectController();
        public ViewSubjects()
        {
            InitializeComponent();
            LoadSubejct(GetAllSubject());
        }

        private SubjectController GetAllSubject()
        {
            return subjectview;
        }
        private void LoadSubejct(SubjectController subjectview)
        {
            var subjectData = SubjectController.GetAllSubject();

            viewtsubjectdata2.DataSource = subjectData;
            viewtsubjectdata2.ReadOnly = true;
            viewtsubjectdata2.ClearSelection();
        }

        private void ViewSubjects_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }

        private void viewtsubjectdata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
