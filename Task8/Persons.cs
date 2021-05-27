using System;

public class Person
{
    private string name;

    public Person(string name)
    { this.name = name; }

    public string Name 
    { 
        get { return name; }
        set { name = value; }
    }

    public virtual void Print()
    {
        Console.WriteLine("Name: {0}.", this.name);
    }
}

public class Staff : Person
{
    private int salary;

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Staff(string name, int salary) : base(name)
    { this.salary = salary; }

    public override void Print()
    {
        Console.WriteLine("Person {0} has salary {1}", Name, this.salary);
    }
}

public class Teacher : Staff
{
    private string subject;
    public string Subject { get; set; }

    public Teacher(string name, int salary, string subject):base(name, salary)
    { this.subject = subject; }

    public override void Print()
    {
        Console.WriteLine("The teacher {0} teaches {1} and earns {2}$.", Name, this.subject, Salary);
    }
}

class Developer : Staff
{
    private string level;
    public string Level { get; set; }

    public Developer(string name, int salary, string level):base(name, salary)
    { this.level = level; }

    public override void Print()
    {
        Console.WriteLine("The developer {0} level is {1} and earns {2}$.", Name, this.level, Salary);
    }

}
