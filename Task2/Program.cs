using System;

namespace Task2
{
    class Program
    {
        const int monthInYear = 12;
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        public struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Please, enter the integer value 1: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the integer value 2: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            bool isRepresentMonth = numberOne <= monthInYear && numberOne > 0;
            Console.WriteLine(isRepresentMonth);
            bool isRepresentMonth2 = numberTwo <= monthInYear && numberTwo > 0;
            Console.WriteLine(isRepresentMonth2);

            bool isRepresentDay = numberOne <= 31 && numberOne > 0;
            Console.WriteLine(isRepresentDay);
            bool isRepresentDay2 = numberTwo <= 31 && numberTwo > 0;
            Console.WriteLine(isRepresentDay2);

            Console.WriteLine("\n");

            //Task 2
            Console.Write("Please, enter the double value 1: ");
            string number = Console.ReadLine();
            int pointPosition = number.IndexOf(".");
            int firstDigitAfterDecimal = Int32.Parse(number[pointPosition + 1].ToString());
            int secondDigitAfterDecimal = Int32.Parse(number[pointPosition + 2].ToString());

            Console.WriteLine($"The sum of the first 2 digits after the point for this number is {firstDigitAfterDecimal + secondDigitAfterDecimal}");

            Console.WriteLine("\n");

            //Task 3
            Console.Write("What time is it? (from 1 to 24, integer value): ");
            int h = Convert.ToInt32(Console.ReadLine());

            if (h >= 6 && h <= 10)
            {
                Console.WriteLine("Good morning!");
            }
            else if (h > 10 && h <= 16)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (h > 16 && h <= 21)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }

           //Task 4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);

            Console.WriteLine("\n");

            //Task 5

            RGB black;
            black.red = 0;
            black.green = 0;
            black.blue = 0;

            RGB white;
            white.red = 255;
            white.green = 255;
            white.blue = 255;
        }
    }
}