using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HW9.part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> linesFromText = new List<string>();
            string path = @"C:\Users\user\source\repos\HW9.part2\toHW9.part2.txt";
            string singleLine;

            using (StreamReader sr = new StreamReader(path))
            {
                while((singleLine = sr.ReadLine()) != null)
                {
                    linesFromText.Add(singleLine);
                }
            }

            List<int> amountOfChars = new List<int>();

            int i = 0;
            foreach (string line in linesFromText)
            {
                i++;
                int amount = line.Count();
                amountOfChars.Add(amount);

                Console.WriteLine($"In line {i} there is {amount} symbols.");
            }

            Console.WriteLine();

            Console.WriteLine($"The largest line has {amountOfChars.Max()} symbols.");
            Console.WriteLine($"The shortest line has {amountOfChars.Min()} symbols.");

            Console.WriteLine();

            Console.WriteLine("Lines, which consist of word \"var\".");
            var stringsWithVar = linesFromText.Where(line => line.Contains("var"));
            foreach(string line in stringsWithVar)
            {
                Console.WriteLine(line);
            }
        }
    }
}
