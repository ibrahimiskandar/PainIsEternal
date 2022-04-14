using System;
using Course__Managment_Application.Enum;
using System.Collections.Generic;

namespace Course__Managment_Application


{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Student> students = new List<Student>();
            bool check = true;
            while (check)
            {
                
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t[Course Management Application]\n\n" +
                    "[1]- Yeni qrup yarat\n" +
                    "[2]- Qrupların siyahısını göstər\n" +
                    "[3]- Qrup üzərində düzəliş etmək\n" +
                    "[4]- Qrupdakı tələbələrin siyahısını göstər\n" +
                    "[5]- Bütün tələbələrin siyahısını göstər\n" +
                    "[6]- Tələbə yarat\n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("\t\t\t\t\t[Qrup Yaratmaq]\n\n");
                        Console.WriteLine("\t\t\tIxtisasi Secimini edin:\n\n" +
                           "[1]- Programming\n" +
                           "[2]- Design\n" +
                           "[3]- System Administration\n");

                        Categories category = new Categories();
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                category = Categories.Programming;
                                break;
                            case 2:
                                category = Categories.Design;
                                break;
                            case 3:
                                category = Categories.System_Administration;
                                break;
                            default:
                                Console.WriteLine("Uygun secim secin!!");
                                break;
                        }
                        Console.WriteLine("\t\t\tTehsil Formasini secin :\n\n" +
                           "[1]- Online\n" +
                           "[2]- Offline\n");
                        bool isonline = false;
                        int checkonline = Convert.ToInt32(Console.ReadLine());
                        switch (checkonline)
                        {
                            case 1:
                                isonline = true;
                                break;
                            case 2:
                                isonline = false;
                                break;
                            default:
                                Console.WriteLine("Uygun secim secin!!");
                                break;
                        }
                        Group group = new Group(category, isonline);

                        
                        groups.Add(group);
                        break;
                    case 2:
                            foreach (var item in groups)
                            {
                                Console.WriteLine($"Grup adi: {item.No}\nIxtisas: {item.Category}\nFormat: {item.IsOnline}");

                            }
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("duz sec");
                        break;

                }
            }
        }

    }
}
