using System;

namespace HW8
{
    abstract class Shape: IComparable
    {
        private string name;

        public string Name { 
            get { return name; } 
            set { name = value; } 
        }

        public Shape(string _name)
        {
            name = _name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(object compareObject)
        {
            Shape otherObject = (Shape)compareObject;
            return this.Area().CompareTo(otherObject.Area());
        }
    }

    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                {
                    Console.WriteLine("The radius cannot be less than zero.");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Circle(string name, double _radius) : base(name)
        {
            radius = _radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set
            {
                if (side < 0)
                {
                    Console.WriteLine("The side cannot be less than zero.");
                }
                else
                {
                    side = value;
                }
            }
        }

        public Square(string name, double _side) : base(name)
        {
            side = _side;
        }

        public override double Area()
        {
            return Math.Pow(side, 2);
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}
