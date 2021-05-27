using System;

namespace Task3
{
    class Drink
    {
        public string name;
        public decimal price;

       public Drink(string Name, decimal Price)
        {
            name = Name;
            price = Price;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Please, enter the value a (integer): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the value b (integer): ");
            int b = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = a; i <= b; i++ )
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of in the range, which are divided by 3 without remainder is {count}.");

            Console.WriteLine("\n");

            //Task 2
            Console.Write("Please, enter the character sting: ");
            string text = Console.ReadLine();
            var text2 = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    text2 += text[i];
                }
            }
            Console.WriteLine(text2);

            Console.WriteLine("\n");

            //Task 3
            Drink product1 = new Drink("Coffee", 5.30m);
            Drink product2 = new Drink("Tea", 4.15m);
            Drink product3 = new Drink("Juice", 6.20m);
            Drink product4 = new Drink("Water", 1.70m);

            Console.WriteLine("Please, choose a product and enter its name: ");
            Console.WriteLine("Coffee");
            Console.WriteLine("Tea");
            Console.WriteLine("Juice");
            Console.WriteLine("Water");

            string chosenDrink = Console.ReadLine();

            switch (chosenDrink)
            {
                case "Coffee":
                    Console.WriteLine($"You chose {product1.name}. Its price - {product1.price}$");
                    break;
                case "Tea":
                    Console.WriteLine($"You chose {product2.name}. Its price - {product2.price}$");
                    break;
                case "Juice":
                    Console.WriteLine($"You chose {product3.name}. Its price - {product3.price}$");
                    break;
                case "Water":
                    Console.WriteLine($"You chose {product4.name}. Its price - {product4.price}$");
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n");

            //Task 4
            Console.Write("Please, enter the integer value: ");
            int inputValue;
            int countValue = 0;
            int sum = 0;
            double average;

            while ((inputValue = Convert.ToInt32(Console.ReadLine())) >= 0)
            {
                sum += inputValue;
                countValue++;
            }

            average = (double)sum / (double)countValue;

            Console.WriteLine ("The arithmetic average is : {0:N2}", average);

            Console.WriteLine("\n");
            // Task 5
            Console.WriteLine("Please, enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isYearLeap = DateTime.IsLeapYear(year);
            if (isYearLeap == true)
            {
                Console.WriteLine($"The year {year} is leap.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not leap.");
            }

            Console.WriteLine("\n");
            //Task 6
            Console.Write("Please, enter the integer value: ");
            int value = Int32.Parse(Console.ReadLine());
            int summ = 0;
            for (int i = value; i > 0; summ += i % 10, i /= 10);
            Console.WriteLine($"The sum of the entered value is {summ}");

            Console.WriteLine("\n");
            //Task 7
            Console.Write("Please, enter the integer value: ");
            bool isOnlyOddNumbers = true;
            ConsoleKeyInfo valueOne;

            do
            {
                valueOne = Console.ReadKey();
                int number;
                bool converted = Int32.TryParse(valueOne.KeyChar.ToString(), out number);

                if (converted && number % 2 == 0)
                {
                    isOnlyOddNumbers = false;
                }

            } while (valueOne.Key != ConsoleKey.Enter);
            
            if (isOnlyOddNumbers == true)
            {
                Console.WriteLine("This value contains only odd numbers");
            }
            else
            {
                Console.WriteLine("This value also contains even numbers");
            }
            
        }
    }
}
