using System;

public class Worker : Human
{
	decimal weekSalary;
	int hoursPerDay;
	public Worker()
	{
	}
	public Worker(string name, string lname, decimal weekSalary, int hoursPerDay) : base(name, lname)
	{
		WeekSalary = weekSalary;
		HoursPerDay = hoursPerDay;

	}
	protected decimal WeekSalary
	{
		get { return weekSalary; }
		set
		{
			if (value < 10)
				throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
			else
				weekSalary = value;
		}
		}
	protected int HoursPerDay
	{
		get { return hoursPerDay; }
		set
		{
			if (value < 0 && value > 12)
				throw new ArgumentException($"Expected value mismatch! Argument: hoursPerDay");
			else
				hoursPerDay = value;
		}
	}
    public override void ShowInfo()
    {
        base.ShowInfo();
		Console.WriteLine($"Week salary: {WeekSalary :F2} \n Hours per day: {HoursPerDay} \n Salary per hour: {SalaryPerHour()}");
    }
    protected decimal SalaryPerHour()
	{
		decimal salaryPerDay = WeekSalary / 7;
		decimal salaryPerHour = salaryPerDay / 12;
		return salaryPerHour;
	}

}
