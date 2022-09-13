using System;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is even");
            }
            else
            {
                Console.WriteLine(n + " is odd");
            }
        }
    }
}
