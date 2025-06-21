using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Lecturer
    {
        public int LectureID { get; internal set; }
        public string LecturerName { get; set; }
        public string SubjectName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Dateofbirth { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        
    }
}
