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
    public partial class Management_login : Form
    {
        public Management_login()
        {
            InitializeComponent();
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {          
            {
                Mainlogin managementForm = new Mainlogin();
                managementForm.Show();
                this.Hide(); 
            }
            
        }

        private void Management_login_Load(object sender, EventArgs e)
        {
            Mainlogin mainLogin = new Mainlogin();     
        }
    }
}
