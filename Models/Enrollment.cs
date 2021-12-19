using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_Front_72190307.Models
{
    public class Enrollment
    {
        
        public string studentID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime enrollmentDate { get; set; }

        public int enrollmentID { get; set; }

        public string grade { get; set; }

        public int courseID { get; set; }

        public string title { get; set; }

        public int credits { get; set; }

    }
}