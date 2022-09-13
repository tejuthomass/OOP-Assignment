using System;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, temp;
                
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
                
            for (temp = n; n > 0; n /= 10)
            {
                sum = (sum * 10) + (n % 10);
            }

            if (temp == sum)
            {
                Console.WriteLine(temp + " is Palindrome.");
            }
            else
            {
                Console.WriteLine(temp + " is not Palindrome.");
            }
        }
    }
}
