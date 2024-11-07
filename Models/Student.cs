using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_App_V1._0.Models
{
    internal class Student
    {
        public int PrimaryID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string number { get; set; }
        public string StudentProgram { get; set; }
        public Boolean IsEnroled { get; set; }

        public Student()
        {
            PrimaryID = 0;
            StudentID = null;
            StudentName = null;
            number = null;
            StudentProgram = null;
            IsEnroled = false;
        }

        public Student(int primaryID, string studentID, string name, string num, string program, bool isEnroled)
        {
            PrimaryID = primaryID;
            StudentID = studentID;
            StudentName = name;
            number = num;
            StudentProgram = program;
            IsEnroled = isEnroled;
        }
    }
}
