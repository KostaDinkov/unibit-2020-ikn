using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var myList = new int[] { 1, 2, 3, 4, 5 };

        foreach( var num in myList)
        {
            Console.WriteLine(num);
        }

        var( min, max, _) = Range(myList);
        Console.WriteLine($"min:{min}, max:{max}");
        
    }

    static (int, int, int) Range(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        
        return (min, max, 5);
    }
}
