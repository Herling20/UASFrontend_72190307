using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_Front_72190307.Models
{
    public class Student
    {
        public string studentID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime enrollmentDate { get; set; }

        public Enrollment Enrollment { get; set; }
    }
}