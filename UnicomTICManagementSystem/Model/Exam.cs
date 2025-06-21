using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Exam
    {
        public int Id { get; set; } 
        public string SubjectName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
