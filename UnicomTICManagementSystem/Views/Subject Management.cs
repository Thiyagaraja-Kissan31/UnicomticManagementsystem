using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;
using static System.Collections.Specialized.BitVector32;

namespace UnicomTICManagementSystem.Views
{
    public partial class Subject_Management : Form
    {
        private SubjectController subjectController = new SubjectController();

        public Subject_Management()
        {
            InitializeComponent();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            subjectdataGridView1.DataSource = null;
            subjectdataGridView1.DataSource = SubjectController.GetAllSubject();
            subjectdataGridView1.ClearSelection();
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void Subject_Management_Load(object sender, EventArgs e)
        {
            
        }
    
        private void addbtn_Click(object sender, EventArgs e)
        {
            var subject = new Subject
            {
                SubjectName = subjecttxt.Text.Trim()
            };
            subjectController.AddSubject(subject);
            LoadSubjects();
            subjecttxt.Clear();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (subjectdataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(subjectdataGridView1.SelectedRows[0].Cells["Id"].Value);
                var subject = new Subject
                {
                    Id = id,
                    SubjectName = subjecttxt.Text.Trim()
                };
                subjectController.UpdateSubject(subject);
                LoadSubjects();
                subjecttxt.Clear();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (subjectdataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(subjectdataGridView1.SelectedRows[0].Cells["Id"].Value);
                subjectController.DeleteSubject(id);
                LoadSubjects();
                subjecttxt.Clear();
            }
        }


        private void subjectdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subjectdataGridView1.SelectedRows.Count > 0)
            {
                subjecttxt.Text = subjectdataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString();
            }
        }
    }    
}
