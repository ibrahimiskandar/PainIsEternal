using System;

namespace Encapsulation
{
    /*Aşağıda qeyd olunanlar eyni taska aiddir.
a:)Student classimiz var- id,ad ,soyad, ixtisas kimi propertiler

b:)Group

classimiz   var- name, maxStuCount ve students array-i(hansi ki telebeleri saxlayacaq)
c;)Group-un addStudent() ve RemoveStudent() metodlari yazilmalidir8*/

    class Program
    {
        static void Main(string[] args)
        {
            Group student = new Group("BP201", 19);
            student.AddStudent("Eli", "Agayev", "CS");
            student.AddStudent("ibrahim", "iskar", "CS");
            student.AddStudent("ibrahim", "ikandar", "CS");
            student.AddStudent("ibahim", "iskadar", "CS");
            student.AddStudent("Eli", "Agayev", "CS");
            student.AddStudent("Eli", "Agayev", "CS");
            student.AddStudent("Eli", "Agayev", "CS");

            student.RemoveStudent("Eli", "Agayev", "CS");
            student.GetStudents();

        }
    }
}
