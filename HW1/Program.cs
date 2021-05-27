using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.Write("Please, enter the value for a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The area of square is {Math.Pow(a, 2)}.");
            Console.WriteLine($"The perimeter of square is {a * 4}.");

            // Task 2
            Console.WriteLine("\n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you {name}?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, you are {age} years old.");

            //Task 3
            Console.WriteLine("\n");
            Console.WriteLine("Please, enter the radius value");
            double r = Double.Parse(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine($"The length of the circle is {Math.Round((2 * pi * r), 2)}");
            Console.WriteLine($"The area of the circle is {Math.Round((pi * r * r), 2)}");
            Console.WriteLine($"The volume of the circle is {Math.Round((4 / 3 * pi * r * r * r), 2)}");
        }
    }
}
