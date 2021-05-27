using System;

namespace HW2
{
    class Program
    {
        enum HttpError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402

        }

        public struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return $"{Name}, {Mark}, {Age}";
            }
        }

        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Please, enter the number 1 (type float): ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Please, enter the number 2 (type float): ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Please, enter the number 3 (type float): ");
            float n3 = float.Parse(Console.ReadLine());

            bool areTheyBelong = (n1 <= 5 && n1 >= -5) && (n2 <= 5 && n2 >= -5) && (n3 <= 5 && n3 >= -5);
            Console.WriteLine(areTheyBelong);

            Console.WriteLine("\n");

            //Task 2
            Console.Write("Please, enter the number 1 (type integer): ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number 2 (type integer): ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number 3 (type integer): ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(number1, Math.Max(number2, number3));
            int min = Math.Min(number1, Math.Min(number2, number3));
            Console.WriteLine($"The maximum value is {max}");
            Console.WriteLine($"The minimum value is {min}");

            Console.WriteLine("\n");

            //Task 3
            Console.Write("Please, enter the HTTP status code (400/401/402): ");
            int value = Convert.ToInt32(Console.ReadLine());
            HttpError status = (HttpError)value;
            Console.WriteLine(status.ToString());

            Console.WriteLine("\n");
            //Task 4
            Dog myDog;
            Console.WriteLine("Please, enter the dog name: ");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Please, enter the dog mark: ");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine("Please, enter the dog age: ");
            myDog.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write($"My Dog is: {myDog}.");
        }
    }
}
