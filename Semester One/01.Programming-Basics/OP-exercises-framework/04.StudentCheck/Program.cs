
using System;

namespace _04.StudentCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the year of your birth: ");
            int yearOfBirth;
            do
            {
                yearOfBirth = int.Parse(Console.ReadLine());

            } while (yearOfBirth < 1920 || yearOfBirth > 2020);

            int currenYear = DateTime.Now.Year;
            int age = currenYear - yearOfBirth;

            string response = $"{name}, you are a";

            if (age < 18)
            {
                if (age < 1)
                {
                    Console.WriteLine($"May be {name} isn't born yet.");
                }
                Console.WriteLine($"{response} student.");
            }
            else
            {

                Console.WriteLine($"{response} worker.");
            }
        }
    }
}
