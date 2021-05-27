using System;
using System.Collections.Generic;
using System.IO;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string path = @"C:\phones.txt";
            string outputPath = @"C:\Users\user\source\repos\HW7\Phones.txt";
            string singleLine;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (StreamWriter sw = new StreamWriter(outputPath, false))
                {

                    while ((singleLine = sr.ReadLine()) != null)
                    {
                        string[] parts = singleLine.Split("-");
                        PhoneBook.Add(parts[0], parts[1]);
                        sw.WriteLine(parts[1]);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                foreach (string contact in PhoneBook.Keys)
                {
                    Console.WriteLine(contact);
                }

                Console.WriteLine();

                Console.Write("Please enter the name: ");

                string name = Console.ReadLine();

                Console.WriteLine($"Phone Number: {PhoneBook[name]}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                string newPath = @"C:\Users\user\source\repos\HW7\New.txt";

                using (StreamWriter sw = new StreamWriter(newPath, false))
                {
                    foreach (string number in PhoneBook.Values)
                    {
                        if (number.StartsWith("80"))
                        {
                            sw.WriteLine($"+3{number}");
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
