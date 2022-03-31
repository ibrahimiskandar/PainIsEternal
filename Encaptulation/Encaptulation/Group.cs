using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Group
    {
        public string Name { get; set; }
        public int MaxCount = 0;

        public Student[] students = new Student[0];

        public Group(string name, int maxcount)
        {
            Name = name;
            if (maxcount <= 30)
            {
                MaxCount = maxcount;
            }
            else
            {
                Console.WriteLine(" bu qeder adami hara yigirsan");
            }

        }
        public void AddStudent(string name, string surname, string speciality)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = new Student(name, surname, speciality);
        }
        public void GetStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Name: { item.Name}\nSurname: { item.Surname}\nSpeciality: { item.Speciality}\n");
            }
        }

        public void RemoveStudent(string name, string surname, string speciality)
        {
            if (students.Length == 0)
            {
                Console.WriteLine("Sinifde sagird yoxdur!!");
                return;
            }
            Student[] newstudents = new Student[0];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == name && students[i].Surname == surname && students[i].Speciality == speciality)
                {
                    continue;

                }
                Array.Resize(ref newstudents, newstudents.Length + 1);
                newstudents[newstudents.Length - 1] = students[i];
            }
            students = newstudents;
        }
    }
}
