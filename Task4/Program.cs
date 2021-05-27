using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "grey", 100000.76);
            Car car2 = new Car("BMW", "black", 150000.00);
            Car car3 = new Car("Lanos", "green", 50000.00);

            double car1NewPrice = car1.ChangePrice(-10);
            Console.WriteLine("The {0} price is {1:0.00}$", car1.name, car1NewPrice);
            double car2NewPrice = car2.ChangePrice(-10);
            Console.WriteLine("The {0} price is {1:0.00}$", car2.name, car2NewPrice);
            double car3NewPrice = car3.ChangePrice(-10);
            Console.WriteLine("The {0} price is {1:0.00}$", car3.name, car3NewPrice);

            car3.Color = "white";
        }
    }
}
