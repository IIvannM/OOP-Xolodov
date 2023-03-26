using System;

namespace SummationCalculator
{
    class Program//public
    {
        static void Main(string[] args) //public
        {
            double sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum += Math.Pow(i, 2) / Math.Sqrt(Math.Pow(3, i) + Math.Pow(2, i));
            }
            // JAVA System.out.println("The sum of the expression (i^2) / (square root of (3^i + 2^i)) from i = 0 to i = 10 is: " + sum);
            Console.WriteLine("The sum of the expression (i^2) / (square root of (3^i + 2^i)) from i = 0 to i = 10 is: " + sum);
            Console.ReadKey();
        }
    }
}
