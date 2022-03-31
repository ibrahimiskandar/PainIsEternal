
using System;

namespace namespacetask
{
    /*1.1 Student class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq
 və hər dəfə yeni bir Student obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Surname
- Age
- Point
- ShowInfo() - student-in bütün məlumatlarını geriyə qaytaracaq.

ps: Name, surname, point dəyərləri olmadan student obyekti yaratmaq olmaz

1.2 Group class
- No - qıraqdan set etmək olmayacaq yalnız get etmək olacaq hər dəfə yeni bir Group obyekt yaradıldıqda avtomatik qrup nömrəsinin rəqəm hissəsi bir vahid artacaq
ilk yaradılacaq qrupun qrup nönmrəsi BP201 olacaq
ikinci dəfə qrup yaradan zaman avtomatik BP202
olacaq bu şəkildə hər dəfə yeni qrup yaradılanda rəqəm hissəsi artacaq.
- Students array
- AddStudent() - bu metod studnet type-da studnet qebul edir ve Students array-e elave edir(Bunu axırıncı task da etmisiz və Array.Resize methodundan istifadə edə bilərsiz)
- GetAllStudents() - geriyə bütün studentləri qaytaracaq.

- Sort() - parametr olaraq heç nə qəbul etməyəcək, Students arrayindəki studentləri Point dəyərlərinə görə sort edib(azdan çoxa sıralamaq) geriyə bir Student tipindən sort olunmuş bir array qaytaracaq*/
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            Group group = new Group(i++);
            group.AddStudent(new Student(j++, "Ibrahim", "ISkandar", 20, 31));
            group.AddStudent(new Student(j++, "Ibo", "asdaw", 20, 31));
            group.AddStudent(new Student(j++, "Murad", "afaw", 20, 40));


        }
    }
}
