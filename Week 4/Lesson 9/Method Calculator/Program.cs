using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" 1-CI EDEDI DAXIL EDIN : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" 2-CI EDEDI DAXIL EDIN : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" SIMVOLU DAXIL EDIN : ");
                char option = Convert.ToChar(Console.ReadLine());
                Calculator(a, b, option);
            }
        }

        public static void Calculator(int a, int b, char option)
        {
            switch (option)
            {
                case '-':
                    Console.WriteLine($" CAVAB : {a - b}");
                    break;
                case '+':
                    Console.WriteLine($" CAVAB : {a + b}");
                    break;
                case '*':
                    Console.WriteLine($" CAVAB : {a * b}");
                    break;
                case '/':
                    Console.WriteLine($" CAVAB : {a / b}");
                    break;
                default:
                    Console.WriteLine("Bele bir isare movcud deyil ! ");
                    break;
                }
        }
    }
    
}
