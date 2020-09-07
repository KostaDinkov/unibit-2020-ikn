using System;

class Program
{
    static void Main()
    {
        //declaring and initializing variables
        int a = 5;
        double b = 0.2;

        //writing to the console
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Number a = {0} and b = {1}",a,b);
        //same with
        Console.WriteLine($"Your numbers are: {a} and {b}");

        //and array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        //convert a boolean to integer
        int truthy = Convert.ToInt32(true);

        Console.WriteLine(numbers.Length);


        
    }
}

