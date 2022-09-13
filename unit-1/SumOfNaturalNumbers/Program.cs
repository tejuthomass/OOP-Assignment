using System;

namespace SumOfNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
