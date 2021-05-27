using System;
using System.Collections.Generic;
using System.IO;


namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Teacher("Oksana", 1400, "Mathematics"));
            persons.Add(new Developer("Petro", 3500, "Middle"));
            persons.Add(new Teacher("Ivan", 1500, "Physics"));
            persons.Add(new Developer("Olena", 1200, "Junior"));
            persons.Add(new Teacher("Ivanna", 1500, "English"));
            persons.Add(new Developer("Oleksandr", 4000, "Senior"));
            persons.Add(new Teacher("Bohdan", 1400, "Ukrainian language and literature"));
            persons.Add(new Developer("Sofiia", 1000, "Junior"));

            foreach (Person person in persons)
            {
                 person.Print();
            }

            Console.WriteLine();

            Console.Write("Please, enter the person's name: ");
            var input = Console.ReadLine();
            bool found = false;

            Console.WriteLine();

            foreach (Person person in persons)
            {
                if (input == person.Name)
                {
                    person.Print();
                    found = true;
                }
            }

            Console.WriteLine();

            if (!found)
            {
                Console.WriteLine("Name not found.");
                Console.WriteLine();
            }

            persons.Sort((person, otherPerson) => person.Name.CompareTo(otherPerson.Name));

            using (StreamWriter sr = new StreamWriter(@"C:\Users\user\source\repos\Task8\fileToTask8.txt"))
            {
                foreach (Person person in persons)
                {
                    sr.WriteLine(person.Name);
                    Console.WriteLine(person.Name);
                }
            }

            Console.WriteLine();

            List<Staff> employees = new List<Staff>();

            foreach (Person person in persons)
            {
                if (person is Staff)
                {
                    employees.Add(person as Staff);
                }
            }

            employees.Sort((person, otherPerson) => person.Salary.CompareTo(otherPerson.Salary));

            foreach (Staff employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.Salary}$");
            }
        }
    }
}
