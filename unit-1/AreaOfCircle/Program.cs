using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.Write("Enter Radius: ");
            radius = double.Parse(Console.ReadLine());
            // radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;
            
            Console.WriteLine("\nArea of circle: " + area);
        }
    }
}
