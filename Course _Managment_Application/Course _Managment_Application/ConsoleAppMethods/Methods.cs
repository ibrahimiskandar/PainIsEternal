using System;
using Course__Managment_Application.Enum;
using System.Collections.Generic;

namespace Course__Managment_Application.ConsoleAppMethods
{
    class Methods
    {
        public static void MainMenu()
        {
            Console.WriteLine("\t\t\t\t\t[[Course Management Application]]\n\n" +
                "[1]- Create a new group\n" +
                "[2]- Show group list\n" +
                "[3]- Edit group\n" +
                "[4]- Show the list of students by group\n" +
                "[5]- Show list of all students\n" +
                "[6]- Create Student\n");
            switch (Console.ReadLine())
            {
                case "1":
                    CreateGroup();
                    break;
                case "2":
                    ShowGroupInfo();
                    break;
                case "3":
                    EditGroup();
                    break;
                case "4":
                    ShowByGroup();
                    break;
                case "5":
                    ShowStudents();
                    break;
                case "6":
                    CreateStudent();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You can only choose one of the numbers given in the Menu !!!");
                    break;
            }

        }
        public static void CreateGroup()
        {
            #region Info
            // Summary:
            //     Yeni qrup yarat - bu əməliyyat seçildikdə istifadəçidən yeni qrup yaradılması üçün lazımi məlumatları console-dan 
            //     daxil etməsi istənilməlidir. Daxil edilən dəyər qrup şərtlərinə uyğun olmasa yenidən daxil etməsi tələb olunmalıdır.
            #endregion
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t[Create A Group]\n\n");
            Console.WriteLine("\t\tChoose Specialty:\n\n" +
               "[1]- Programming\n" +
               "[2]- Design\n" +
               "[3]- System Administration\n");

            Categories category = new Categories();
            switch (Console.ReadLine())
            {
                case "1":
                    category = Categories.Programming;
                    break;
                case "2":
                    category = Categories.Design;
                    break;
                case "3":
                    category = Categories.System_Administration;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You can only choose one of the numbers given in the Menu !!!");
                    return;
            }
            Console.WriteLine("\t\tSelect the Education Type (Online or Offline) :\n\n" +
               "[1]- Online\n" +
               "[2]- Offline\n");
            bool isonline;
            switch (Console.ReadLine())
            {
                case "1":
                    isonline = true;
                    Console.Clear();
                    break;
                case "2":
                    isonline = false;
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You can only choose one of the numbers given in the Menu !!!");
                    return;
            }
            Group group = new Group(category, isonline);
            Group.Groups.Add(group);
            Console.WriteLine($"\n\tThe Group [{group.No}] was created successfully\n");
        }


        public static void ShowGroupInfo()
        {
            #region Info
            // Summary:
            //     Qrupların siyahısını göstər - bu əməliyyat seçildikdə console pəncərəsinə sistemdə var olan bütün qrupların
            //     nömrələri, növləri və tələbə sayları göstərilməlidir
            #endregion
            Console.Clear();
            if (Group.Groups.Count > 0)
            {
                Console.WriteLine(" [All Groups]\n\n");
                foreach (var item in Group.Groups)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no existing groups!");
            }
        }


        public static void EditGroup()
        {
            #region Info
            // Summary:
            //     Qrup üzərində düzəliş etmək - bu əməliyyat seçildikdə birinci növbədə istifadəçidən üzərində dəyişiklik ediləcək
            //     qrup nömrəsini daxil etməsi tələb olunmalıdır, daha sonra həmin qrupun yeni nömrəsinin
            //     daxil edilməsi tələb olunmalıdır.Qrupun yalnız nömrəsi dəyişdirilə bilər.Bu halda sistemdə
            //     yeni adda qrup olub olmadığı yoxlanılmalıdır.Əgər o adda qrup varsa istifadəçiyə xəta mesajı verib yenidən daxil etməsi tələb olunmalıdır.
            #endregion
            if (Group.Groups.Count > 0)
            {
                bool check = false;
                while (check == false)
                {

                    Console.WriteLine("\t\t\t\t\t[Edit Group]\n\n");
                    Console.WriteLine($"\t\tAvailable groups :\n\n");
                    foreach (var item in Group.Groups)
                    {
                        Console.WriteLine($"{item.No}\n");
                    }
                    Console.WriteLine("\t\tEnter the name of the group to be Renamed:\n\n");
                    string group = Console.ReadLine();
                    foreach (var item in Group.Groups)
                    {
                        if (group == item.No)
                        {

                            Console.WriteLine("\t\tEnter the new name:\n\n ");
                            int no;
                            while (!int.TryParse(Console.ReadLine(), out no))
                            {
                                Console.Write("The value must be number, try again: ");
                            }
                            foreach (var group1 in Group.Groups)
                            {
                                while ($"{group1.Category} " + no == group1.No)
                                {
                                    Console.Write("This group already exists, try again: ");
                                    while (!int.TryParse(Console.ReadLine(), out no))
                                    {
                                        Console.Write("The value must be number, try again: ");
                                    }
                                }
                            }
                            item.No = $"{item.Category} {no}";
                            Console.Clear();
                            Console.WriteLine($"\n\tThe Group [{item.No}] was re-named successfully\n");
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tThe group you entered does not exist!!\n");

                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\tThere are no existing groups!\n");
            }
        }


        public static void ShowByGroup()
        {
            #region Info
            // Summary:
            //     Qrupdakı tələbələrin siyahısını göstər - bu əməliyyat seçildikdə istifadəçidən hansı qrupdakı tələəbələrin 
            //     siyahısını görmək istəyirsə həmin qrupun nömrəsini daxil etməsi istənilməlidir. Əgər daxil edilən
            //     nömrəli qrup yoxdursa istifadəçiyə xəta mesajı göstərib proses menu-suna qaytarmalıdır.
            #endregion
            if (Group.Groups.Count > 0)
            {
                bool check = true; ;
                while (check)
                {
                    Console.WriteLine("\t\tGroups:\n");
                    foreach (var item in Group.Groups)
                    {
                        Console.WriteLine(item.No);
                    }
                    Console.WriteLine("\n\t\tEnter the name of the group whose students you want to see:\n");
                    string no = Console.ReadLine();

                    foreach (var item in Group.Groups)
                    {
                        if (no == item.No)
                        {
                            check = false;
                            if (item.Students.Count > 0)
                            {
                                foreach (var item1 in item.Students)
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine(item1.ToString());

                                }
                            }
                            else
                            {
                                Console.WriteLine($"\t\tThere are no existing Students in group {item.No}\n");
                                break;
                            }

                        }

                    }
                    if (check == true)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tThe group you entered does not exist!!\n");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\tThere are no existing groups!\n");
            }

        }

        public static void ShowStudents()
        {
            #region Info
            // Summary:
            //     Bütün tələbələrin siyahısını göstər - bu əməliyyat seçildikdə sistem daxilindəki bütün tələbələrin siyahısı
            //     göstərilməlidir. (Tələbə adı, qrup nömrəsi, online olub olmamağı)
            #endregion
            Console.Clear();
            if (Group.Groups.Count > 0)
            {
                Console.WriteLine("\t\tStudents:\n");
                foreach (var group in Group.Groups)
                {
                    if (group.Students.Count > 0)
                    {
                        foreach (var item in group.Students)
                        {

                            Console.WriteLine(item.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\t\tThere are no existing Students in any group\n");
                    }
                }
            }
            else
            {
                Console.WriteLine($"\t\tThere are no existing groups\n");
            }
        }

        public static void CreateStudent()
        {
            #region Info
            // Summary:
            //     Tələbə yarat - bu əməliyyat seçildikdə istifadəçidən tələbə yaranması üçün lazım olan məlumatların
            //     daxil edilməsi tələb olunmalıdır.
            #endregion
            if (Group.Groups.Count > 0)
            {
                bool check = true;
                while (check)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t[Create Student]\n\n");
                    Console.WriteLine("\t\tEnter the name of the student:\n");
                    string fullname = Console.ReadLine().Trim();
                    Console.WriteLine("\t\t\tSelect the Education Form(Guaranteed||Unguaranteed) :\n\n" +
                       "[1]- Guaranteed\n" +
                       "[2]- Unguaranteed\n");
                    bool istype = false;
                    string checkonline = Console.ReadLine();
                    switch (checkonline)
                    {
                        case "1":
                            istype = true;
                            break;
                        case "2":
                            istype = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("You can only choose one of the numbers given in the Menu !!!");
                            break;
                    }
                    Console.WriteLine("\t\tAvailable Groups:\n");
                    foreach (var item in Group.Groups)
                    {
                        Console.WriteLine($"{item.No}\n--------------------------------");
                    }
                    Console.WriteLine("\n\t\tEnter the name of the group you want to add the student to: \n");
                    string no = Console.ReadLine();

                    Student student = new Student(fullname, no, istype);
                    foreach (var item in Group.Groups)
                    {
                        if (no == item.No)
                        {
                            item.AddStudent(student);
                            check = false;
                        }
                    }
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There is no group with this name!\n");
                    }

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("There are no existing groups!");
            }

        }
    }
}
