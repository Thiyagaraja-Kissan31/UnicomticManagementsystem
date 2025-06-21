using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Mark
    {
        public int MarksID { get; internal set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string Marks { get; set; }
        public string Date {  get; set; }
       
    }
}
