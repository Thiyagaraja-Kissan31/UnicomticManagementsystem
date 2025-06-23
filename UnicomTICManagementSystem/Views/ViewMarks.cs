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
    public partial class ViewMarks : Form
    {
        private MarkController markview = new MarkController();
        private Form previousForm;
        private string selectedRole;
        public ViewMarks()
        {
            InitializeComponent();
            LoadMarks(GetAllMarks());
        }
        public ViewMarks(Form prevForm, string role)
        {
            InitializeComponent();
            previousForm = prevForm;
            selectedRole = role;
            LoadMarks(GetAllMarks());
        }
        private MarkController GetAllMarks()
        {
            return markview;
        }
        private void LoadMarks(MarkController markview)
        {
            var marksData = markview.GetAllMarks();

            viewmarksdata2.DataSource = marksData;
            viewmarksdata2.ReadOnly = true;
            viewmarksdata2.ClearSelection();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void ViewMarks_Load(object sender, EventArgs e)
        {

        }

        private void viewmarksdata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
