<Query Kind="Program" />

void Main()
{
	5.IsBetween(3, 7).Dump();
	10.IsBetween(1, 5).Dump();

	"b".IsBetween("a", "c").Dump();
	"z".IsBetween("a", "b").Dump();
	"b".IsBetween("b", "c").Dump();
}

void DoSomething<T>(T t)
{
	typeof(T).Name.Dump("TypeOfTSource");
	t.Dump();
}

void DoNothing<TSource>()
{
	typeof(TSource).Name.Dump("TypeOfTSource");
}

public class CompareToTester : IComparable<CompareToTester>
{
	public int Value { get; }
	public CompareToTester(int value)
	{
		Value = value;
	}
	public int CompareTo(CompareToTester obj)
	{
		if(obj == null) throw new InvalidOperationException();
		
		return obj.Value > Value 
			? 1
			: obj.Value == Value 
				? 0
				: -1;
	}
}

public static class Extensions
{
//	public static bool IsBetween(this int number2Check, int from, int till)
//	{
//		return number2Check.CompareTo(from) > 0
//			&& number2Check.CompareTo(till) < 0;
//	}
//
//	public static bool IsBetween(this string number2Check, string from, string till)
//	{
//		return number2Check.CompareTo(from) > 0
//			&& number2Check.CompareTo(till) < 0;
//	}

	public static bool IsBetween<TComparable>(this TComparable number2Check, TComparable from, TComparable till)
		where TComparable : IComparable
	{
		return number2Check.CompareTo(from) > 0
			&& number2Check.CompareTo(till) < 0;
	}
}