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

        public static List<Group> Groups;

        public List<Student> students;

        public Group(Categories category, bool isonline)
        {
            IsOnline = isonline;

            switch (category)
            {
                case Categories.Programming:
                    No = $"BP{BP++}";
                    break;
                case Categories.Design:
                    No = $"BD{BP++}";
                    break;
                case Categories.System_Administration:
                    No = $"BS{BP++}";
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
            return $"No: {No}\nCategory: {Category}\nType : {result}";
        }
        
    }
}
