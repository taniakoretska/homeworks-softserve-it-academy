using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string text = "Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text";
            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            for (int i = 0; i < text.Length; i ++ )
            {
                if (text[i] == 'a')
                {
                    countA++;
                }
                else if (text[i] == 'o')
                {
                    countO++;
                }
                else if (text[i] == 'i')
                {
                    countI++;
                }
                else if (text[i] == 'e')
                {
                    countE++;
                }
            }

            Console.WriteLine($"There are {countA} letters 'a' in this text.");
            Console.WriteLine($"There are {countO} letters 'o' in this text.");
            Console.WriteLine($"There are {countI} letters 'i' in this text.");
            Console.WriteLine($"There are {countE} letters 'e' in this text.");


            Console.WriteLine("\n");
            //Task 2
            Console.Write("Please, enter the number of month, where 1 is January and 12 is December: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"This month has {DateTime.DaysInMonth(DateTime.Now.Year, numberOfMonth)} days.");

            Console.WriteLine("\n");

            //Task 3
            int[] values = new int[10];
            bool allPositive = true;
            Console.WriteLine("Please, enter 10 integer values: ");
            
            for (int i = 0; i < 10; i++)
            {
                values[i] = Int32.Parse(Console.ReadLine());

                if (values[i] < 0 && allPositive)
                {
                    allPositive = false;
                }
            }

            if (allPositive)
            {
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    sum += values[i];
                }
                Console.WriteLine($"The sum is {sum}");

            }
            else
            {
                int product = 1;

                for (int i = 5; i < 10; i++)
                {
                    product *= values[i];
                }

                Console.WriteLine($"The product is {product}");
            }
        }
    }
}
