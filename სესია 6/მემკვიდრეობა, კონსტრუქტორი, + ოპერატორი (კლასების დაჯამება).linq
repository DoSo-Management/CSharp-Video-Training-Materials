<Query Kind="Program" />

void Main()
{
	//new C().Dump();
	var x1 = new PositiveNumberNonZero(5);
	var x2 = new PositiveNumberNonZero(10);

	//var x3 = new PositiveNumberNonZero(x1.Value + x2.Value);
	var x3 = x1 + x2;
	x3.Dump();

	//new PositiveNumber(5, true).Dump();


	//new Email("luka.surmava@gmail.com").Dump();

	return;

	var x =
		Enumerable
		.Range(10, 10)
		.Select(i => i.ToString())

	.Dump();
}

public class MoneyWithCurrency
{
	public PositiveNumberZero Amount { get; }
	public string CurrencyCode { get; }
}

public enum AllowZeroEnum
{
	AllowZero,
	DisallowZero
}

public class PositiveNumberNonZero : PositiveNumber
{
	public PositiveNumberNonZero(decimal value) : base(value, AllowZeroEnum.DisallowZero)
	{

	}
	
	public static PositiveNumberNonZero operator +(PositiveNumberNonZero x1, PositiveNumberNonZero x2)
		=> new PositiveNumberNonZero(x1.Value + x2.Value);
}

public class PositiveNumberZero : PositiveNumber
{
	public PositiveNumberZero(decimal value) : base(value, AllowZeroEnum.AllowZero)
	{ }
}

public abstract class PositiveNumber
{
	PositiveNumber(decimal value, bool allowZero)
	{
		if (value < 0) throw new InvalidOperationException();
		if (!allowZero && value == 0)
			throw new InvalidOperationException();

		Value = value;
	}

	protected PositiveNumber(decimal value, AllowZeroEnum allowZero)
		: this(value, allowZero == AllowZeroEnum.AllowZero)
	{

	}

	public decimal Value { get; }
}

//public class PositiveNonZeroNumber : PositiveNumber
//{
//	public PositiveNonZeroNumber(decimal value) : base(value)
//	{
//
//	}
//}