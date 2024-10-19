

using System.Text;

public class Book
{
	string author;
	string title;
	protected decimal price;
	protected string Title
	{
		get { return title; }
		set { if (Char.IsDigit(value[0]))
				throw new ArgumentException("Author not valid!");
			else
				title = value; }
	}
	public virtual decimal Price
	{
		get { return price; }
		set
		{
			if (value <= 0)
				throw new ArgumentException("Price not valid");
			else
				price = value;
		}
	}
	protected string Author
	{
		get
		{return author;}
		set
		{
			if (value.Length < 3)
				throw new ArgumentException("Title not valid!");
			else
				author = value;
		}
	}
	public Book(string title, string author, decimal price)
	{
		this.Title = title;
		this.Author = author;
		this.Price = price;
	}
	public Book()
	{

	}
	public override string ToString()
	{
		var resultBuilder = new StringBuilder();
		resultBuilder.AppendLine($"{this.GetType().Name}")
			.AppendLine($"Title: {this.Title}")
			.AppendLine($"Author: {this.Author}")
			.AppendLine($"Price: {this.Price:F2}");
		string result = resultBuilder.ToString().TrimEnd();
		return result;

	}

}
