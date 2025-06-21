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
    public partial class ViewTimetable : Form
    {
        private TimetableController timetableview = new TimetableController();
        public ViewTimetable()
        {
            InitializeComponent();
            LoadTimetable(GetTimetableview());
        }

        private TimetableController GetTimetableview()
        {
            return timetableview;
        }

        private void LoadTimetable(TimetableController timetableview)
        {
            var timetableData = timetableview.GetAllTimetables();

            viewtimetabledata2.DataSource = timetableData;
            viewtimetabledata2.ReadOnly = true;
            viewtimetabledata2.ClearSelection();
        }  

        private void ViewTimetable_Load(object sender, EventArgs e)
        {

        }

        private void viewtimetabledata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Login userLogin = new User_Login();
            userLogin.Show();
        }
    }
}
