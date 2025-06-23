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
    public partial class Attendance_Management : Form
    {
        private AttendanceController AttendanceController = new AttendanceController();
        public Attendance_Management()
        {
            InitializeComponent();
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AttendanceController.GetAllAttendance();
            dataGridView1.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void Attendance_Management_Load(object sender, EventArgs e)
        {
            var students = AttendanceController.GetAllAttendance(); 
            name.DataSource = students;
            name.DisplayMember = "StudentName";

            var subjects = SubjectController.GetAllSubject();
            subjectnametextbox.DataSource = subjects;
            subjectnametextbox.DisplayMember = "SubjectName";
            subjectnametextbox.ValueMember = "Id";

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var Attendance = new Attendance
            {
                StudentName = name.Text,
                SubjectName = subjectnametextbox.Text,
                Date = dateofbirthTextBox1.Text,
                Status = statuscombobox.Text

            };
            AttendanceController.AddAttendance(Attendance);
            MessageBox.Show("SuccesFully Add StudentAttendance!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAttendance();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                name.Text = dataGridView1.SelectedRows[0].Cells["AttendanceID"].Value.ToString();
            }
        }

        private void Deletebtn1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int AttendanceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AttendanceId"].Value);
                AttendanceController.DeleteAttendance(AttendanceId);
                LoadAttendance();

            }
        }
    }
}
