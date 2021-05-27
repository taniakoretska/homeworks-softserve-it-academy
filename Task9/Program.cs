using System;
using System.Collections.Generic;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 and 2
            int[] numbers = { 4, -5, 7, 8, -10, 258, -14, 69, 89, -1 };

            int[] negativeNumbers = numbers.Where(n => n < 0).ToArray();
            int[] positiveNumbers = numbers.Where(n => n > 0).ToArray();

            Console.WriteLine("The array with negative numbers: ");
            foreach (int element in negativeNumbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("The array with positive numbers: ");
            foreach (int element in positiveNumbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            //Task 3
            int largestNumber = numbers.Max();
            int smallestNumber = numbers.Min();

            int sum = numbers.Sum();

            Console.WriteLine($"The largest number is {largestNumber} and the smallest is {smallestNumber}. The sum of array is {sum}.");
            
            Console.WriteLine();

            //Task 4
            Console.WriteLine($"The average sum of the array is {numbers.Average()}");
            int[] lessThanAverageNumbers = numbers.Where(n => n < numbers.Average()).ToArray();
            Console.WriteLine($"The first largest element in array that is smaller than the average of elements is {lessThanAverageNumbers.Max()}");

            Console.WriteLine();

            //Task 5

            IEnumerable<int> numbersSorted = numbers.OrderBy(c => c);
            Console.WriteLine("The sorted array: ");
            Console.WriteLine(String.Join("\n", numbersSorted));

        }
    }
}
