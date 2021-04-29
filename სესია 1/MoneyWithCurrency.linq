<Query Kind="Program" />

void Main()
{
	var myEmail = new MoneyWithCurrency(15, "GEL").Dump();
	var myEmail2 = new MoneyWithCurrency(20, "USD").Dump();

	
	//var email = "petre.chitashvili@gmail.com".Dump();
}

public class MoneyWithCurrency
{
	public MoneyWithCurrency(double amount, string currencyName)
	{
		if (amount < 0) throw new InvalidOperationException("Amount can't be < 0");
		if (string.IsNullOrWhiteSpace(currencyName)) throw new InvalidOperationException("currencyName must be valid");

		Amount = amount;
		CurrencyName = currencyName;
	}

	public double Amount { get; }
	public string CurrencyName { get; }
}