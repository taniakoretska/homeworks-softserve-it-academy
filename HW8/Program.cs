using System;
using System.Collections.Generic;

namespace HW8
{
    class Program
    {
        private static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Please choose if you want to enter Square (0) or Circle (1): ");
                    int type = Int32.Parse(Console.ReadLine());
                    Shape inputShape;

                    switch (type)
                    {
                        case 0:
                            {
                                Console.Write("Please enter the square name: ");
                                string name = Console.ReadLine();
                                Console.Write("Please enter the square side: ");
                                double side = Double.Parse(Console.ReadLine());
                                inputShape = new Square(name, side);
                                break;
                            }
                        case 1:
                            {
                                Console.Write("Please enter the circle name: ");
                                string name = Console.ReadLine();
                                Console.Write("Please enter the circle radius: ");
                                double radius = Double.Parse(Console.ReadLine());
                                inputShape = new Circle(name, radius);
                                break;
                            }
                        default:
                            throw new ArgumentException("The choice must be 0 or 1");
                    }

                    shapes.Add(inputShape);

                    Console.WriteLine("Shape Name: {0}; Shape Area: {1:N2}; Shape Perimeter: {2:N2}", inputShape.Name, inputShape.Area(), inputShape.Perimeter());
                    Console.WriteLine();
                }
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Shape maxPerimeter = shapes[0];

            for (int i = 1; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > maxPerimeter.Perimeter())
                {
                    maxPerimeter = shapes[i];
                }
            }

            Console.WriteLine("The shape with the largest perimeter is {0} with perimeter {1:N2}", maxPerimeter.Name, maxPerimeter.Perimeter());

            Console.WriteLine();

            shapes.Sort();
            
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: {0}; Area: {1};", shape.Name, shape.Area());
            }
        }
    }
}
