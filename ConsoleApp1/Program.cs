using System;
class Program
{
    static void Main()
    {
        MenuForTask();

    }
    static void MenuForTask()
    {
        string title;
        string author;
        decimal price;
        try
        {
            Console.WriteLine("Enter title of book");
            title = Console.ReadLine();
            Console.WriteLine("Enter author of book");
            author = Console.ReadLine();
            Console.WriteLine("Enter price of book");
            price = decimal.Parse(Console.ReadLine());
            Book book = new Book(title, author, price);
            Console.WriteLine(book.ToString());
            GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title,author,price);
            Console.WriteLine(goldenEditionBook.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}