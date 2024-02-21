using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__TYPES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> city = new Dictionary<string, string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ölkə adını daxil edin:");
                string country = Console.ReadLine();

                Console.WriteLine("Paytaxt adını daxil edin:");
                string capital = Console.ReadLine();

                city[country] = capital;
            }
          
            while (true)
            {
                Console.WriteLine("Ölkə adını daxil edin (Proqramdan çıxmaq üçün 'exit' yazın):");
                string countryInput = Console.ReadLine();

                if (countryInput.ToLower() == "exit")
                    break;

                if (countryInput.ToLower() == "all")
                {
                    foreach (var kvp in city)
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
                else
                {
                    if (city.ContainsKey(countryInput))
                    {
                        string capital = city[countryInput];
                        Console.WriteLine($"Ölkə: {countryInput}, Paytaxt: {capital}");
                    }
                    else
                    {
                        Console.WriteLine("Daxil edilən ölkə tapılmadı.");
                    }
                }
                List<int> numbers = new List<int>();

                Console.WriteLine("10 ədəd daxil edin:");
                for (int i = 0; i < 10; i++)
                {
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }

                
                for (int i = 0; i < 5; i++)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[numbers.Count - 5 + i];
                    numbers[numbers.Count - 5 + i] = temp;
                }

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

    }
        
}
    

