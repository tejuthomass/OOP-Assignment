using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, reverse;
            
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            
            for (reverse = 0;  n != 0; n /= 10)
            {
                reverse = (reverse * 10) + (n % 10);
            }
       
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
