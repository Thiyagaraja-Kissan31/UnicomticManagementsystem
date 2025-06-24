using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Views;


namespace UnicomTICManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseManager.CreateTables();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Management_login());
            ;
            
        }
    }
}
