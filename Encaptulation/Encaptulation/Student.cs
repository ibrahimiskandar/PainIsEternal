using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Student
    {
        public int Id = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Speciality { get; set; }

        
        public Student(string name, string surname, string speciality)
        {
            Name = name;
            Surname = surname;
            Speciality = speciality;

        }
    }
}
