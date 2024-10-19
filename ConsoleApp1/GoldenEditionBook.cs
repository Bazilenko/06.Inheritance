using System;

public class GoldenEditionBook : Book
{
	public GoldenEditionBook()
	{
	}
	public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
	{
	}
	public override decimal Price
	{
		get { return base.price * (decimal)1.3; }

	}
}
