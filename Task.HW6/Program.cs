using System;

namespace Task.HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Task 1
            int[] numbers = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string numberInput = Console.ReadLine();

                if (numberInput.Contains(".") || numberInput.Contains(","))
                {
                    throw new ArgumentException("Double is not allowed");
                }

                numbers[i] = Int32.Parse(numberInput);
            }

            try
            {
                Console.WriteLine("{0:0.00}", Div(numbers[0], numbers[1]));
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Can not divide by zero.");
            }*/

            // Task 2

            Console.WriteLine("Enter 10 numbers (1 < a1 < ... < a10 < 100):");

            int[] inputNumbers = new int[10];

            try
            {
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    inputNumbers[i] = ReadNumber(1, 100);

                    if (i > 0 && inputNumbers[i] < inputNumbers[i - 1])
                    {
                        throw new ArgumentException("Each item must be greater than its predecessor.");
                    }
                }
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static int ReadNumber(int start, int end)
        {
            // TryParse Tryes to Parse value from console, but doesn't throw an error
            bool parsed = Int32.TryParse(Console.ReadLine(), out int input);

            if (!parsed)
            {
                throw new ArgumentException("Invalid value entered.");
            }

            if (input <= start || input >= end)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }

            return input;
        }

        /*static double Div(int number1, int number2)
        {
            // Need to cast to double to get the correct division result with decimal part
            double result = (double)number1 / (double)number2;

            // If the result of division of two doubles is ∞ that's result of zero-division
            if (double.IsInfinity(result))
            {
                throw new DivideByZeroException();
            }

            return result;
        }*/
    }
}
