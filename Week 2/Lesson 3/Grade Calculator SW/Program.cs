using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator_SW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's score: ");
            int attendanceScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the student's exam score: ");
            int examScore = Convert.ToInt32(Console.ReadLine());

            int totalScore = attendanceScore + examScore;
            Console.WriteLine($"Total Score: {totalScore}, Grade: {totalScore}");

            switch (totalScore / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }


        }
    }
}
