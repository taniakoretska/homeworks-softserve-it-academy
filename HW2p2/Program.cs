using System;
using System.Collections.Generic;

namespace HW2p2
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary <uint, string> persons= new Dictionary<uint, string>();
            int count = 1;
            string value;

            for (var i = 0; i < 7; i++)
            {
                Console.Write("Please, enter the name: ");
                value = Console.ReadLine();
                persons.Add((uint)(count ++), value);
            }

            Console.WriteLine(string.Join(", ", persons));

            Console.Write("Please, enter ID: ");
            uint index = Convert.ToUInt32(Console.ReadLine());

            switch (index)
            {
                case 1:
                    Console.WriteLine(persons[0]);
                    break;
                case 2:
                    Console.WriteLine(persons[1]);
                    break;
                case 3:
                    Console.WriteLine(persons[2]);
                    break;
                case 4:
                    Console.WriteLine(persons[3]);
                    break;
                case 5:
                    Console.WriteLine(persons[4]);
                    break;
                case 6:
                    Console.WriteLine(persons[5]);
                    break;
                case 7:
                    Console.WriteLine(persons[6]);
                    break;
                default:
                    Console.WriteLine("The user with such ID doesn't exist in this Dictionary.");
                    break;

            }

        }
    }
}
