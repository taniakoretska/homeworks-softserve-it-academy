using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] objectsArray = new Person[6];
            for (var i = 0; i < objectsArray.Length; i++)
            {
                objectsArray[i] = new Person();
                objectsArray[i].Input();
                Console.WriteLine($"The name is {objectsArray[i].Name} and age {objectsArray[i].Age()}.");
            }

            for (var i = 0; i < objectsArray.Length; i++)
            {
                if (objectsArray[i].Age() < 16)
                {
                    objectsArray[i].Output();
                    objectsArray[i].Output();
                }
            }

            Console.WriteLine("Persons with the same names: ");
            for (int i = 0; i < objectsArray.Length; i++)
            {
                for (int j = i+1; j < objectsArray.Length; j++)
                {
                    if (objectsArray[i] == objectsArray[j])
                    {
                        objectsArray[i].Output();
                        objectsArray[j].Output();
                    }
                }
            }

           

        }
    }
}
