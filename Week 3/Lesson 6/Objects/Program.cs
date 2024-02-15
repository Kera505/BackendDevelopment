using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic[] studentlist2 =
            //{
            // new { Name = "Kerem", Surname = "Eyvazov" , Age= "21"},
            // new { Name = "Bahar" , Surname = "Huseynova" , Age = "19"},
            // new { Name = "Ismayil", Surname = "Rzayev" , Age= "24"},
            // new { Name = "Huseyn", Surname = "Hesenov", Age = "18" }

            //};
            //foreach (var item in studentlist2) 
            //{ 
            //    Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age);
            //}
            ArrayList sdlist = new ArrayList();
            while (true)
            {
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Surname :");
                string surname = Console.ReadLine();
                Console.Write("Age :");
                byte age = Convert.ToByte(Console.ReadLine());
                object student = new { Name = name, Surname = surname, Age = age };
                sdlist.Add(student);
                Console.WriteLine(name + " " + surname + " " + age + " Added");

                Console.WriteLine("Choose an operation: \n (1: Add, 2: Delete , 3: Show all students , 4: Exit )");
                byte selection = Convert.ToByte(Console.ReadLine());
                if (selection == 4)
                {
                    Console.WriteLine("Exiting the program...");
                    break;

                }
                else if (selection == 3)
                {
                    foreach (dynamic item in sdlist)
                    {
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age);
                        break;
                    }
                  }
                else if (selection == 2)
                {
                 Console.WriteLine("Write student name:");
                 string removeStudentName = Console.ReadLine();
                    foreach (dynamic item in sdlist)
                        if (item.Name == removeStudentName)
                        {
                            sdlist.Remove(item);
                            Console.WriteLine("The student whose name was entered has been deleted !");
                        }
                        else
                        {
                            Console.WriteLine("The student name you entered was not found !");
                            break;
                        }
                }
            }
         }
        }
    }

