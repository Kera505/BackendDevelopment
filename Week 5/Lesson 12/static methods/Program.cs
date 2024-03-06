using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods
{
    internal class Program
    {
        public static bool IsContainsDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsEven(int numb)
        {
            return numb % 2 == 0;
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin : ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isOdd = IsOdd(number);
            if (isOdd)
            {
                Console.WriteLine($"{number} tekdir: {isOdd}");
            }
            else
            {
                Console.WriteLine($"{number} cutdur: {isOdd}");
            }

            Console.WriteLine("Ededi daxil edin : ");
            int numb = Convert.ToInt32(Console.ReadLine());
            bool isEven = IsEven(number);
            if (isEven)
            {
                Console.WriteLine($"{numb} cutdur: {isEven}");
            }
            else
            {
                Console.WriteLine($"{numb} tekdir: {isEven}");
            }
 
            Console.WriteLine("Daxilinde reqemler olan soz daxil edin : ");
            string input = Console.ReadLine();
            bool containsDigit = IsContainsDigit(input);
            Console.WriteLine($"Daxil edilmiş string daxilinde reqem simvolu : {containsDigit}");
          
            Console.ReadLine();
        }
    }
}
