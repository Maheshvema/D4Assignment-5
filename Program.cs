using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Score;
            Console.WriteLine("Enter The Percentage To Find Grading");
            Score =int.Parse(Console.ReadLine());
            if (Score >= 90)
            {
                Console.WriteLine("Grading:A");
            }
            else if (Score >= 80 && Score <= 89)
            {
                Console.WriteLine("Grading:B");
            }
            else if (Score >= 70 && Score <= 79)
            {
                Console.WriteLine("Grading:C");
            }
            else if (Score >= 60 && Score <= 69)
            {
                Console.WriteLine("Grading:D");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadKey();
        }
    }
}
