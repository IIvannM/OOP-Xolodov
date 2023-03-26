using System;
//import java.lang.*;

namespace ProductCalculator
{
    class Program //+ public
    {
        static void Main(string[] args) //+public
        {
            double product = 1;

            for (int i = 1; i <= 5; i++)
            {
                product *= Math.Sqrt(i) / (Math.Pow(i + 1, 1.0 / 3.0) + 1);
            }
            //System.out.println("The product of the expression √i / (i^(1/3) + 1) from 1 to 5 is: " + product);
            Console.WriteLine("The product of the expression √i / (i^(1/3) + 1) from 1 to 5 is: " + product);
            Console.ReadKey();
        }
    }
}
