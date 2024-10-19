using System;

public class Student : Human
{
	int facultyNumber;
	public Student()
	{

	}
	public Student(string name, string lname, int facultNumber) : base(name, lname)
	{
		FacultyNumber = facultNumber;
	}
	protected int FacultyNumber
	{
		get { return facultyNumber; }
		set
		{
			if (value < 5 && value > 10)
				throw new ArgumentException("Invalid faculty number!");
			else
				facultyNumber = value;
		}
	}
	public override void ShowInfo()
	{
		base.ShowInfo();
		Console.WriteLine($"Faculty number : {FacultyNumber}");
	}
}
