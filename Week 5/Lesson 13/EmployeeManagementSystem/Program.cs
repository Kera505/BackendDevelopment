using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    using System;

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string department, string name, int age, decimal salary) : base(name, age, salary)
        {
            Department = department;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();

           
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            Employee employee = new Employee("Elekber Yasamalli", 50, 5000);
            Console.WriteLine("Employee Details:");
            employee.PrintDetails();
            Console.WriteLine();

            Manager manager = new Manager("Marketing", "Perviz Bulbule", 35, 7000);
            Console.WriteLine("Manager Details:");
            manager.PrintDetails();

            Console.Read();
        }
    }

}
