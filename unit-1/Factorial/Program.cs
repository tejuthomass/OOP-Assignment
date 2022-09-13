using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = n; i > 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine(n + "! = " + fact);
        }
    }
}