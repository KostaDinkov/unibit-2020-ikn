//A program that takes two sides of a rectangle and prints the perimeter to the console

using System;

namespace Rectangle
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double b = double.Parse(Console.ReadLine());

            double perimeter = 2 * a + 2 * b;

            //note: the syntax below is using a feature of c# v6 - string interpolation
            Console.WriteLine($"Perimeter of a rectangle with sides a={a} and b={b} is: \n{perimeter}");
        }
    }
}
