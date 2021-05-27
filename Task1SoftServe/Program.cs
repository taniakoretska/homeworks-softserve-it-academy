using System;

namespace Task1SoftServe
{
    class Program
    {

        static void Main(string[] args)
        {
            // Point 1

            Console.WriteLine("Task 1");
            Console.WriteLine("\n");
            Console.WriteLine("Please, enter the value a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter the value b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int result_add = a + b;
            Console.WriteLine($"a + b = {result_add}");

            int result_subtract = a - b;
            Console.WriteLine($"a - b = {result_subtract}");

            int result_multiply = a * b;
            Console.WriteLine($"a * b = {result_multiply}");

            int result_divide = a / b;
            Console.WriteLine($"a / b = {result_divide}");
            Console.WriteLine("\n");

            // Point 2
            Console.WriteLine("Task 2");
            Console.WriteLine("\n");
            Console.WriteLine("How old are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer + ".");
            Console.WriteLine("\n");

            // Point 3
            Console.WriteLine("Task 3");
            Console.WriteLine("\n");
            char firstOne = 'q';
            char secondOne = 'w';
            char thirdOne = 'e';

            Console.WriteLine($"You enter {firstOne}, {secondOne}, {thirdOne}.");
            Console.WriteLine("\n");

            // Point 4
            Console.WriteLine("Task 4");
            Console.WriteLine("\n");
            int numberOne = 4;
            int numberTwo = 7;

            bool areTheyPositive = (numberOne > 0 && numberTwo > 0);
            Console.WriteLine(areTheyPositive);








        }
    }
}
