﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapperDevExpress.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
