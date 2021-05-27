using System;

class Person
{
	private string name;
	private DateTime birthYear;

	// Properties
   
	public string Name
    {
		get { return name; }
    }

	public DateTime BirthYear
    {
		get { return birthYear; }
    }

	// Constructors

	public Person()
    {
		name = "Unknown";
		birthYear = new DateTime(2000, 01, 01);
	}

	public Person(string Name, DateTime BirthYear)
    {
		name = Name;
		birthYear = BirthYear;
    }

	// Methods
	public int Age ()
    {
		return DateTime.Now.Year - birthYear.Year;
    }

	public void Input()
    {
		Console.WriteLine("Please, enter the name: ");
		name = Console.ReadLine();
		Console.WriteLine("Please, enter the year of birth: ");
		int birthYearInput = Int32.Parse(Console.ReadLine());
		birthYear = new DateTime(birthYearInput, 01, 01);
    }

	public void ChangeName(string newName)
    {
		name = newName;
    }

	public void Output()
    {
		Console.WriteLine($"The name: {name}, the birth year: {birthYear.ToString("yyyy")}.");
    }

	public static bool operator == (Person person1, Person person2)
    {
		return person1.name == person2.name;
    }

	public static bool operator != (Person person1, Person person2)
	{
		return person1.name != person2.name;
	}
}
