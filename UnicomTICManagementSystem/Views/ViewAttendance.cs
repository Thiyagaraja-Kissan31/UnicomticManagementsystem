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
    public partial class VIewAttendance : Form
    {
        private AttendanceController attendanceview = new AttendanceController();
        private Form previousForm;
        private string selectedRole;

        public VIewAttendance()
        {
            InitializeComponent();
            LoadAttendance(GetAttendance());
           
        }
        public VIewAttendance(Form prevForm, string role)
        {
            InitializeComponent();
            previousForm = prevForm;
            selectedRole = role;
            LoadAttendance(GetAttendance());
        }
        private AttendanceController GetAttendance()
        {
            return attendanceview;
        }

        private void LoadAttendance(AttendanceController attendanceview)
        {
            var attendanceData = attendanceview.GetAllAttendance();

            viewattendancedata2.DataSource = attendanceData;
            viewattendancedata2.ReadOnly = true;
            viewattendancedata2.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void viewattendancedata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {

        }
    }
}
