using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\source\repos\HW9\toHW9.txt";

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("circle1", 4.5));
            shapes.Add(new Square("square1", 0.5));
            shapes.Add(new Circle("circle2", 15));
            shapes.Add(new Square("square2", 5.67));
            shapes.Add(new Circle("circle3", 2.35));
            shapes.Add(new Square("square3", 8.8));

            Console.WriteLine("The list of shapes:");
            foreach (Shape sh in shapes)
            {
                Console.WriteLine("Name: {0}, Area {1:N2}, Perimeter {2:N2} ", sh.Name, sh.Area(), sh.Perimeter());
            }

            Console.WriteLine();

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                var shapesInRange = from shape in shapes
                                    where shape.Area() >= 10 && shape.Area() <= 100
                                    select shape;

                Console.WriteLine("The shapes, which area are in range [10 - 100]: ");
                sw.WriteLine("The shapes, which area are in range [10 - 100]: ");

                foreach (Shape sh in shapesInRange)
                {
                    Console.WriteLine($"Name: {sh.Name}, Area: {sh.Area():N2}");
                    sw.WriteLine($"Name: {sh.Name}, Area: {sh.Area():N2}");
                }

                Console.WriteLine();
                sw.WriteLine();

                var shapesWithA = from shape in shapes
                                  where shape.Name.Contains('a')
                                  select shape;

                Console.WriteLine($"The list of shapes names, which contains letter 'a': ");
                sw.WriteLine($"The list of shapes names, which contains letter 'a': ");

                foreach (Shape sh in shapesWithA)
                {
                    Console.WriteLine(sh.Name);
                    sw.WriteLine(sh.Name);
                }
            }

            Console.WriteLine();

            shapes.RemoveAll(sh => sh.Perimeter() < 5);

            Console.WriteLine($"The shapes with removed items:");
            foreach (Shape sh in shapes)
            {
                Console.WriteLine("Name: {0}, Area {1:N2}, Perimeter {2:N2}", sh.Name, sh.Area(), sh.Perimeter());
            }
        }
    }
}
