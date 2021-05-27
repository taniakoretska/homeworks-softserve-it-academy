using System;
using System.IO;
using System.Collections.Generic;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            try
            {
                StreamReader reader = new StreamReader("C:\\data.txt");
                List<string> lines = new List<string>();
                string singleLine;
                while ((singleLine = reader.ReadLine()) != null)
                {
                    lines.Add(singleLine);
                }
                File.WriteAllText("C:\\rez.txt", String.Join("\n", lines));
                reader.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Please launch the program with admin rights.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No data file found.");
            }

            Console.WriteLine();

            try
            {
                using (StreamReader reader = new StreamReader("C:\\dataSw.txt"))
                using (StreamWriter writer = new StreamWriter("C:\\rezSw.txt", false))
                {
                    string singleLine;

                    while ((singleLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(singleLine);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Please launch the program with admin rights.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No data file found.");
            }

            Console.WriteLine();

            // Task 2
            string disc = "C:\\";
            string writePath = @"C:\Users\user\source\repos\Task7\DirectoryC.txt";
            try {
                using (StreamWriter swriter = new StreamWriter(writePath, true))
                {
                    if (Directory.Exists(disc))
                    {
                        swriter.WriteLine("Directories: ");

                        DirectoryInfo di = new DirectoryInfo(disc);

                        DirectoryInfo[] directories = di.GetDirectories();
                        foreach (DirectoryInfo element in directories)
                        {
                            swriter.WriteLine(element);
                        }

                        swriter.WriteLine();

                        swriter.WriteLine("Files: ");
                        FileInfo[] files = di.GetFiles();
                        foreach (FileInfo _element in files)
                        {
                            swriter.WriteLine($"{_element} is {(double)_element.Length / (double)1024: 0.00} KB.");
                        }

                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Please launch the program with admin rights.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No data file found.");
            }

            // Task 3

            //no need to create variable because I don't have disc D on my laptop
            try
            {
                Console.WriteLine("Text files on disc C: ");
                Console.WriteLine();

                DirectoryInfo dirInfo = new DirectoryInfo(disc);
                FileInfo[] fileS = dirInfo.GetFiles("*.txt");

                foreach (FileInfo elemenT in fileS)
                {
                    Console.WriteLine($"{elemenT.Name}: ");
                    Console.WriteLine(elemenT
                        .OpenText()
                        .ReadToEnd());
                    Console.WriteLine();
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Please launch the program with admin rights.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No data file found.");
            }
        }
    }

}
