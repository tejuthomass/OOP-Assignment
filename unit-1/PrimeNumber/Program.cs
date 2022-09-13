using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, flag = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime number");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine(n + " is a prime number");
            }
        }
    }
}