using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_App_V1._0.Models
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Program { get; set; }


        public Student()
        {
            StudentID = null;
            Name = null;
            Age = 1;
            Program = null;
        }

        public Student(string studentID, string name, int age, string program)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Program = program;
        }


    }
}
