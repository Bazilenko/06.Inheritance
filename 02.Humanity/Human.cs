using System;

public class Human
{
	string name;
	string lastName;
	public Human()
	{

	}
	public Human(string name, string lastName)
	{
		Name = name;
		LastName = lastName;
	}
	protected string Name {  
		get { return name; }
		set { if (Char.IsLower(value[0]))
				throw new ArgumentException("Expected upper case letter! Argument: name");
            else if (value.Length < 3)
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: name");
            else name = value;
        }
	}
	protected string LastName {  
		get { return lastName; }
		set
		{
			if (Char.IsLower(value[0]))
				throw new ArgumentException($"Expected upper case letter! Argument: lastName");
			else if (value.Length < 2)
				throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
			else lastName = value;
		}
	}
	public virtual void ShowInfo()
	{
		Console.WriteLine($"First Name: {Name}\n Last Name: {LastName}\n");
	}

}
