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

<<<<<<< HEAD
        var( min, max, _) = Range(myList);
=======
        //testing tuples from c#7
        (int min, int max) = Range(myList);
>>>>>>> 50f057a0df79d074c85a53d9591a087ebe90c9ec
        Console.WriteLine($"min:{min}, max:{max}");
        
    }

    static (int, int, int) Range(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();
        
        return (min, max, 5);
    }
}
