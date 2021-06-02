<Query Kind="Program" />

void Main()
{
	new Coffee(1).Dump("უშაქრო ყავა");
	new Coffee(1, 2).Dump("შაქრიანი ყავა");
}

public class Coffee
{
	public Coffee(int coffeeSpoonfuls)
	{
		if (coffeeSpoonfuls <= 0)
			throw new InvalidOperationException("წყალი გდომებია, შენ..!");

		CoffeeSpoonfuls = coffeeSpoonfuls;
	}

	public Coffee(int coffeeSpoonfuls, int sugarSpoonfuls)
		: this(coffeeSpoonfuls)
	{
		SugarSpoonfuls = sugarSpoonfuls;
	}

	public int CoffeeSpoonfuls { get; }
	public int SugarSpoonfuls { get; }
}