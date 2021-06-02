<Query Kind="Program">
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Media</Namespace>
</Query>

void Main()
{
	var zero = new PositiveDecimal(0, true).Dump();
	zero.Add(5).Dump();
	
	//new NonZeroPositiveDecimal(1).Dump();
}

public class PositiveDecimal
{
	//public PositiveDecimal(decimal value) : this(value, false) { }

	public PositiveDecimal(decimal value, bool allowZero)
	{
		if (value < 0)
			throw new InvalidOperationException("Value must be > 0");

		if (!allowZero && value == 0)
			throw new InvalidOperationException("Value cannot be zero");

		Value = value;
	}

	public decimal Value { get; }
	
	public PositiveDecimal Add(int what2Add) => new PositiveDecimal(Value + what2Add, false);
}

//public class NonZeroPositiveDecimal : PositiveDecimal
//{
//	public NonZeroPositiveDecimal(decimal value) : base(value, false)
//	{
//	}
//}
//
//public class AllowZeroPositiveDecimal : PositiveDecimal
//{
//	public AllowZeroPositiveDecimal(decimal value) : base(value, true)
//	{
//	}
//}