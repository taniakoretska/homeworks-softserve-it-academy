using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper[] workers = { new Programmer("C#"), new Programmer("Java"), new Builder("Hammer") };

            foreach (IDeveloper worker in workers)
            {
                worker.Create();
                worker.Destroy();
                Console.WriteLine("\n");
            }

            Array.Sort(workers);

            foreach (IDeveloper worker in workers)
            {
                Console.WriteLine(worker.Tool);
            }
        }
    }

}

interface IDeveloper
{
    string Tool { get; set; }
    public void Create();
    public void Destroy();
}

class Programmer : IDeveloper, IComparable
{
    private string language;

    public string Tool
    {
        get { return language; }
        set { language = value; }
    }

    public int CompareTo(object compareObject)
    {
        IDeveloper otherObject = (IDeveloper)compareObject;
        return String.Compare(this.Tool, otherObject.Tool);
    }

    public Programmer(string Language)
    {
        language = Language;
    }

    public void Create()
    {
        Console.WriteLine("I write on {0} language.", language);
    }

    public void Destroy()
    {
        Console.WriteLine("I deleted a Programmer.");
    }
}

class Builder : IDeveloper, IComparable
{
    private string tool;

    public string Tool
    {
        get { return tool; }
        set { tool = value; }
    }

    public int CompareTo(object compareObject)
    {
        IDeveloper otherObject = (IDeveloper)compareObject;
        return String.Compare(this.Tool, otherObject.Tool);
    }

    public Builder(string _tool)
    {
        tool = _tool;
    }

    public void Create()
    {
        Console.WriteLine("I use {0} while building.", tool);
    }

    public void Destroy()
    {
        Console.WriteLine("I destroyed my work.");
    }
}