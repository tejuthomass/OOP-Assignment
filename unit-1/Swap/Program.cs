using System;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBefore Swap\nA = " + a + "\tB = " + b);
            
            a -= b;
            b += a;
            a = b - a;

            Console.WriteLine("After Swap\nA = " + a + "\tB = " + b);
        }
    }
}
