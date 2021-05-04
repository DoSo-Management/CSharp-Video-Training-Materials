<Query Kind="Program" />

void Main()
{
	//default(string).Dump();
	var cl1 = new Class();
	//cl1.Property = "გამარჯობა!";
	cl1.Dump();

	var cl2 = new Class
	{
		Property = "გამარჯობა!",
		//Property2 = "გამარჯობა2!"
	}.Dump();
}

public class Class
{
	//public string Property2 { get; set; }

	//string getResult() => property + property;

	string property = "Empty";

	public string Property
	{
		get
		{
			var temporaryVariable = property + property;
			return temporaryVariable;
		}
		set
		{
			property = value;
		}
	}
}