using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Staff
    {
        public int Id { get; internal set; }
        public string StaffName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Dateofbirth { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
    }
}
