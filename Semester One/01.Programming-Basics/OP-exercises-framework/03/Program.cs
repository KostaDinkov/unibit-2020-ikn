using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task calculate age of person x if he is born at year y and today is year z

namespace CalculateAge
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the year of your birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            int currenYear = DateTime.Now.Year;
            int age = currenYear - yearOfBirth;

            Console.WriteLine($"{name}, your age is: {age}");


        }
    }
}
