using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinValue
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, -5, 9, 14, 0 };

            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }

            Console.WriteLine(min);
        }
    }
}
