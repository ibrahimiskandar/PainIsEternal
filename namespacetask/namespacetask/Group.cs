using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespacetask

{
    public class Group
    {
        public readonly string No;
        public Student[] students = new Student[0];

        public Group(int i)
        {
            No = "BP" + (200 + i);
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student[] getAllStudents()
        {
            return students;
        }

        public Student[] Sort()
        {
            Student[] studs = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                studs[i] = students[i];
            }

            for (int i = 0; i < studs.Length; i++)
            {
                for (int j = i + 1; j < studs.Length; j++)
                {
                    if (studs[i].Point > studs[j].Point)
                    {
                        Student temp = studs[i];
                        studs[i] = studs[j];
                        studs[j] = temp;
                    }
                }
            }



            return studs;
        }

    }
}