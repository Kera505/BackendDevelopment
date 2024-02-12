using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            foreach (int each in numbers)
            {

                if (each == 5)
                {
                    total++;
                    Console.WriteLine(each);
                }

            }
            Console.WriteLine("Total number of same digits = " + total);

            Console.ReadKey();

            int[] array = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int sum = 0;

            foreach (int number in array)
            {
                sum += number;
            }

            Console.WriteLine("Sum of numbers in the array: " + sum);

            int[] arrays = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            int maxNumber = arrays[0];
            int occurrence = 1;

            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] > maxNumber)
                {
                    maxNumber = arrays[i];
                    occurrence = 1;
                }
                else if (array[i] == maxNumber)
                {
                    occurrence++;
                }
            }

            Console.WriteLine($"Largest number in the array: {maxNumber}");
            Console.WriteLine($"Occurrence of the largest number: {occurrence}");

            Array.Sort(array);

            foreach (int number in array)
            {
                Console.WriteLine(number);

            }

        }
    }
}
