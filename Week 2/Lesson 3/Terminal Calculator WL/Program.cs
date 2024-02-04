using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_Calculator_WL
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

            if (sign == '+')
            {
                Console.WriteLine("Cavab : " + x1 + x2);
                Console.ReadLine();
            }
            else if (sign == '-')
            {
                Console.WriteLine( x1 - x2);
                Console.ReadLine();
            }
            else if (sign == '*')
            {
                Console.WriteLine("Cavab : " + x1 * x2);
                Console.ReadLine();
            }
            else if (sign == '/')
            {
                Console.WriteLine("Cavab : " + x1 / x2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Bele bir simvol sistemde mövcud deyildir ! ");
                Console.ReadLine();
            }

        }
    }
}
