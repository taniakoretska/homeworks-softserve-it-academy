using System;

public abstract class Person
{
	// Fields
	private int taxNumber;
	private string firstname;
	private string lastname;
	private DateTime birthdate;

	//Properties
	public int TaxNumber
    {
        get { return taxNumber; }
        set { taxNumber = value; }
    }

    public string Firstname
    {
        get { return firstname; }
        set { firstname = value; }
    }

    public string Lastname
    {
        get { return lastname; }
        set { lastname = value; }
    }

    public DateTime Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }

    // Constructors
    public Person()
    {
        taxNumber = 0;
        firstname = "Unknown";
        lastname = "Unknown";
        birthdate = 00 - 00 - 0000;
    }

    public Person(int _TaxNumber, string _FirstName, string _LastName, DateTime _BirthDate)
    {
        taxNumber = _TaxNumber;
        firstname = _FirstName;
        lastname = _LastName;
        birthdate = _BirthDate;
    }

    public override string ToString()
    {
        return $"{firsname} {lastname} was born {birthdate} and has such tax number: {taxNumber}.";
    }

    public virtual void Input()
    {
        Console.Write("Enter the first name: ");
        firstname = Console.ReadLine();

        Console.Write("Enter the last name: ");
        lastname = Console.ReadLine();

        Console.Write("Enter tax number: ");
        taxNumber = Int32.Parse(Console.ReadLine());

        string format = "DD/MM/YYYY";

        Console.Write($"Enter the date of birth ({format}): ");
        taxNumber = DateTime.Parse(Console.ReadLine(), format);
    }

    public virtual void Output()
    {
        Console.WriteLine(this);
    }

    public int GetAge()
    {
        DateTime today = DateTime.Today;

        int age = today.Year - birthdate.Year;

        if (birthdate.Date > today.AddYears(-age)) age--;

        return age;
    }
}
