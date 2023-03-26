using System;
//import java.lang.*;

namespace SummationCalculator
{
    class Program //public
    {
        static void Main(string[] args)  //public
        {
            double sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum += Math.Pow(-1, i) / (i + Factorial(i));
            }
            //System.out.println("The sum of the expression (-1)^i / (i + i!) from 0 to 10 is: " + sum);
            Console.WriteLine("The sum of the expression (-1)^i / (i + i!) from 0 to 10 is: " + sum);
            Console.ReadKey();
        }

        static int Factorial(int n) //factorial с маленькой буквы
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
