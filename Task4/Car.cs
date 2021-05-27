using System;

namespace Task4
{
    class Car
    {
        public string name;
        private string color;
        private double price;
        

        public Car()
        {
            name = "Unknown";
            color = "white";
            price = 0.0;
        }

        public Car(string Name, string Color, double Price)
        {
            name = Name;
            color = Color;
            price = Price;
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public void Input()
        {
            Console.Write("Please, enter the car name: ");
            name = Console.ReadLine();
            Console.Write("Please, enter the car color: ");
            color = Console.ReadLine();
            Console.Write("Please, enter the car price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Car: {0}; color:{1}; price:{2:N2}.", name, color, price);
        }
        
        public double ChangePrice(double x)
        {
            return price += (price * x/100);
        }

        public static bool operator == (Car car1, Car car2)
        {
            return car1.name == car2.name && car1.price == car2.price;
        }
        public static bool operator != (Car car1, Car car2)
        {
            return car1.name != car2.name || car1.price != car2.price;
        }


        public override string ToString()
        {
            return $"The car is {name}. It is {color} and costs {price}";
        }
    }
}