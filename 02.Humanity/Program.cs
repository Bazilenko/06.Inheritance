using System;
class Program
{
    static void Main()
    {
        MenuForAddingHuman();
        MenuForAddingStudent();
        MenuForAddingWorker();

    }
    static void MenuForAddingHuman()
    {
        string name;
        string lname;
        Console.WriteLine("Enter first name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        lname = Console.ReadLine();
        try
        {
            Human human = new Human(name, lname);
            human.ShowInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void MenuForAddingStudent()
    {
        string name;
        string lname;
        int number;
        Console.WriteLine("Enter first name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        lname = Console.ReadLine();
        Console.WriteLine("Enter number of faculty: ");
        number = int.Parse(Console.ReadLine());
        try
        {
            Student student = new Student(name, lname, number);
            student.ShowInfo();
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

    }
    static void MenuForAddingWorker()
    {
        string name;
        string lname;
        decimal salary;
        int hours;
        Console.WriteLine("Enter first name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        lname = Console.ReadLine();
        Console.WriteLine("Enter salary per week:");
        salary = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter hours per day: ");
        hours = int.Parse(Console.ReadLine());
        try
        {
            Worker worker = new Worker(name, lname, salary, hours);
            worker.ShowInfo(); 
        }
        catch(Exception ex) {
            Console.Write(ex.Message);
        }
    }

}