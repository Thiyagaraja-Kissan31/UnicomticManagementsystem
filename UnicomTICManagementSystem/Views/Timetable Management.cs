using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Timetable_Management : Form
    {
        private TimetableController timetablecontroller = new TimetableController();
        public Timetable_Management()
        {
            InitializeComponent();
            LoadTimetable();
        }

        private void LoadTimetable()
        {
            timetabledataGridView1.DataSource = null;
            timetabledataGridView1.DataSource = timetablecontroller.GetAllTimetables();
            timetabledataGridView1.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void Timetable_Management_Load(object sender, EventArgs e)
        {
            var subjects = SubjectController.GetAllSubject();
            subjectname1.DataSource = subjects;
            subjectname1.DisplayMember = "SubjectName";
            subjectname1.ValueMember = "Id";

            var lecturerController = new LecturerController();
            var lecturer = lecturerController.GetAllLecturers();
            lecturername1.DataSource = lecturer;
            lecturername1.DisplayMember = "LecturerName";
            lecturername1.ValueMember = "LectureID";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var Timetable = new Timetable
            {
                SubjectName = subjectname1.Text.Trim(),
                LecturerName = lecturername1.Text.Trim(),
                Date = dateTextBox1.Text.Trim()
            };
            timetablecontroller.AddTimetable(Timetable);
            LoadTimetable();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        { 
            if (timetabledataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(timetabledataGridView1.SelectedRows[0].Cells["TimetableID"].Value);
                var Timetable = new Timetable
                {
                    TimetableID = id,
                    SubjectName = subjectname1.Text.Trim(),
                    LecturerName = lecturername1.Text.Trim(),
                    Date = dateTextBox1.Text.Trim()
                };
                timetablecontroller.UpdateTimetable(Timetable);
                LoadTimetable();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (timetabledataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(timetabledataGridView1.SelectedRows[0].Cells["TimetableID"].Value);
                timetablecontroller.DeleteTimetable(id);
                LoadTimetable();
            }
        }


        private void timetabledataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (timetabledataGridView1.SelectedRows.Count > 0)
            {
                subjectname1.Text = timetabledataGridView1.SelectedRows[0].Cells["TimetableID"].Value.ToString();
            }
        }

        private void subjectname_Click(object sender, EventArgs e)
        {

        }
    }
}
