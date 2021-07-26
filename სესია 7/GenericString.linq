<Query Kind="Program" />

void Main()
{
	new Generic2<int> { GenericPropertyT = 5 }.Dump();
	new Generic2<string> { GenericPropertyT = "string" }.Dump();

	new GenericString { GenericPropertyT = "string2", GenericPropertyTY = 5 }.Dump();
}

public abstract class Generic<T, TY>
{
	public T GenericPropertyT { get; set; }
	public TY GenericPropertyTY { get; set; }
}

public class Generic2<T> : Generic<T, int>
{

}

public class GenericString : Generic<string, int> { }