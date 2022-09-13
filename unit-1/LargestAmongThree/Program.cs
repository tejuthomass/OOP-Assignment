using System;

namespace LargestAmongThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter A: ");
            a = int.Parse(Console.ReadLine());
            
            Console.Write("Enter B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter C: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("\n" + a + " is the largest");
            }
            else if (b > c)
            {
                Console.WriteLine("\n" + b + " is the largest");
            }
            else
            {
                Console.WriteLine("\n" + c + " is the largest");
            }
        }
    }
}
