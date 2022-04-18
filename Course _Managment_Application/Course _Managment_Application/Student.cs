using System;
using System.Collections.Generic;
using System.Text;

namespace Course__Managment_Application
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;

        public Student(string name, string groupno, bool type)
        {
            Fullname = name;
            GroupNo = groupno;
            Type = type;
        }

        public override string ToString()
        {
            var result = Type ? "Guaranteed" : "Unguaranteed";
            return $"Fullname: {Fullname}\nGroup No: {GroupNo}\nType: {result}\n--------------------------------------";
        }
    }
}
