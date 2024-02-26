using System;
using System.Collections.Generic;

namespace Student_Class
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public byte Age { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Enter the student name: ");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter the student surname: ");
                string srnm = Console.ReadLine();
                Console.WriteLine("Enter the student age: ");
                byte ag = Convert.ToByte(Console.ReadLine());

                Student student = new Student();
                student.Name = nm;
                student.Surname = srnm;
                student.Age = ag;
               students.Add(student);
            }
        }
    }
}

