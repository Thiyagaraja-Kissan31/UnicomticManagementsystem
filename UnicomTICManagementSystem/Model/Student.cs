﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Model
{
    internal class Student
    {
        public int Id { get; internal set; }
        public string StudentName { get;  set; }
        public string Address { get;  set; } 
        public string Gender { get;  set; }
        public string Date_of_Birth { get;  set; }
        public string SubjectName { get;  set; }
        public string PhoneNumber { get;  set; }
        public string EmailId { get;  set; }

        //Sudent Login Information================================
        public string Username { get;  set; }
        public string Password { get;  set; }
  

    }
}
