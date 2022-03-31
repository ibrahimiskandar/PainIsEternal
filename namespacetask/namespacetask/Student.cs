using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespacetask
{
    public class Student
    {
        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(int id, string name, string surname, int age, int point)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Point = point;
        }
        public void showInfos()
        {
            Console.WriteLine($"Id: {Id} , Name: {Name} , Surname: {Surname} , Age: {Age} , Point: {Point}");
        }
    }
}
