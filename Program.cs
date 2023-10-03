using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;

namespace Kindergarden
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>();
        static List<Group> groups = new List<Group>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our kindergarden!\n");

            Employee Heniek = new(1, "Heniu");
            Cook halina = new(2, "Halina");
            

            Console.WriteLine(Heniek);
            Console.WriteLine(halina);
            

            Initialize();


            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1. Przyjęcie dziecka");
                Console.WriteLine("2. Wyświetl listę grup");
                Console.WriteLine("3. Wyjście (Q)");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AdmitKid();
                        break;
                    case "2":
                        ShowGroupList();
                        break;
                    case "3":
                    case "Q":
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static void Initialize()
        {
            employees.Add(new Manager(1, "Dyrektorka Halina"));
            employees.Add(new Teacher(2, "pani Basia"));
            employees.Add(new Teacher(3, "pani Marysia"));
            employees.Add(new Teacher(4, "pani Kasia"));
            employees.Add(new Cook(5, "kucharka Marzenka"));
            employees.Add(new Cook(6, "kucharka Bożenka"));



            groups.Add(new Group(1, "Muchomorki", (Teacher)employees[1]));
            groups.Add(new Group(2, "Biedronki", (Teacher)employees[2]));
            groups.Add(new Group(3, "Motylki", (Teacher)employees[3]));
        }





        static void ShowGroupList()
        {
            foreach (Group group in groups)
            {
                Console.WriteLine($"Grupa {group.GroupNumber} {group.GroupName} z nauczycielką {group.Teacher.Name}");
                
            }
        }



        static void AdmitKid()
        {
            Console.Write("Podaj imię dziecka: ");
            string name = Console.ReadLine();

            Console.Write("Podaj wiek dziecka: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Group? group = null;

                foreach (Group g in groups)
                {
                    if (age <= g.GroupStartAge)
                    {
                        group = g;
                        break;
                    }
                }

                if (group == null)
                {
                    Console.WriteLine("Nie znaleziono odpowiedniej grupy dla dziecka.");
                }
                else
                {
                    Console.WriteLine($"Dziecko {name} przyjęto do grupy {group.GroupNumber} z nauczycielką {group.Teacher.Name}");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny wiek dziecka.");
            }
        }

        //Kid.ToString();
    }
}
    
