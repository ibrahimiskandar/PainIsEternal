using System;
using System.Collections.Generic;
using System.Text;
using Course__Managment_Application.Enum;

namespace Course__Managment_Application
{
    class Group
    {
        public string No;

        public Categories Category;
        public static int BP = 200;
        public static int BD = 200;
        public static int BS = 200;


        public bool IsOnline;


        private int _limit;
        

        public static List<Group> Groups = new List<Group>();

        public List<Student> Students;

        public Group(Categories category, bool isonline)
        {
            IsOnline = isonline;
            Students = new List<Student>();
            switch (category)
            {
                case Categories.Programming:
                    No = $"{Categories.Programming} {BP++}";
                    break;
                case Categories.Design:
                    No = $"{Categories.Design} {BD++}";
                    break;
                case Categories.System_Administration:
                    No = $"{Categories.System_Administration} {BS++}";
                    break;
                default:
                    Console.WriteLine("Uygun Secim Daxil edin");
                    break;
            }
            Category = category;


        }



        public override string ToString()
        {
            var result = IsOnline ? "Online" : "Offline";
            return $"No: {No}\nCategory: {Category}\nType : {result}\nStudent Count: {Students.Count}\n--------------------------------";
        }
        
        public void AddStudent(Student student )
        {
            _limit = IsOnline ? 15 : 10;

            if (Students.Count < _limit)
            {
                Students.Add(student);
                
                Console.Clear();
                Console.WriteLine($"\n\tThe Student [{student.Fullname}] was created successfully\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\tThis Group is full!!");
                return;
            }
        }
    }
}
