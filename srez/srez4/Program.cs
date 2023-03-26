using System;

namespace SumOfPositiveElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, -2, 3, 4, -5, 6 };
            int n = A.Length;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                }
            }

            Console.WriteLine("The sum of the positive elements of the array is: " + sum);
            Console.ReadKey();
        }
    }
}

/* 
 java code
import java.util.*;

public class SumOfPositiveElements {
    public static void main(String[] args) {
        int[] A = { 1, -2, 3, 4, -5, 6 };
        int n = A.length;
        int sum = 0;

        for (int i = 0; i < n; i++) {
            if (A[i] > 0) {
                sum += A[i];
            }
        }

        System.out.println("The sum of the positive elements of the array is: " + sum);
    }
}

 */