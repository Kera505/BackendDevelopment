using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 - ci ededi daxil edin.");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 - ci ededi daxil edin.");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simvolu daxil edin.( +  -  *  / )");
            char sign = Convert.ToChar(Console.ReadLine());

            switch (sign)
            {

                case '+':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 + x2}");
                    Console.ReadLine();
                    break;
                case '-':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 - x2}");
                    Console.ReadLine();
                    break;
                case '*':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 * x2}");
                    Console.ReadLine();
                    break;
                case '/':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 / x2}");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(" Bele bir simvol sistemde mövcud deyildir ! ");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
