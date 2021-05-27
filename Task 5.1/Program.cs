using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> collection = new List<IFlyable>();
            collection.Add(new Bird("Owl"));
            collection.Add(new Bird("Eagle"));
            collection.Add(new Plane("Mriya"));

            foreach (IFlyable aflyable in collection)
            {
                aflyable.Fly();
            }

            List<int> myColl = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                myColl.Add(new int());
                Console.Write("Please, enter the integer value: ");
                myColl[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine($"The position of number -10 is {i}");
                }
            }

            myColl.RemoveAll(element => element > 20);
            Console.WriteLine($"Selection with removed elements: {string.Join(" ", myColl)}");

            myColl.Insert(1, 1);
            myColl.Insert(7, -3);
            myColl.Insert(4, -4);
            Console.WriteLine($"Selection with inserted elements: {string.Join(";", myColl)}");

            /* myColl[1] = 1;
             myColl[7] = -3;
             myColl[4] = -4;
             Console.WriteLine($"Sellection with inserted elements: {string.Join(";", myColl)}");*/

            myColl.Sort();
            Console.WriteLine($"Sorted elements: {string.Join(";", myColl)}");
        }

    }
}


interface IFlyable
{
    public void Fly();
}

class Bird : IFlyable
{
    public string name;
    public bool canfly;

    public Bird(string Name, bool Canfly = true)
    {
        name = Name;
        canfly = Canfly;
    }

    public void Fly()
    {
        Console.WriteLine($"the bird {name} is flying!");
    }
}

class Plane : IFlyable
{
    public string mark;
    public bool highfly;

    public Plane(string Mark, bool Highfly = true)
    {
        mark = Mark;
        highfly = Highfly;
    }

    public void Fly()
    {
        Console.WriteLine($"{mark} is on the way!");
    }
}

