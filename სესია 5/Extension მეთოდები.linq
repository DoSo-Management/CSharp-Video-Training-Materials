<Query Kind="Program" />

void Main()
{
	5.Add(3).Dump();
		
	Extensions.GetMeParameter(5).Dump();
	5.GetMeParameter().Dump();

	var c1 = new Skola();
	var c2 = new Skola();
	
	c1.GetMeClassParameter().Dump();
}

public static class Extensions
{
	public static int GetMeParameter(this int intParam) => intParam * intParam;
	public static int GetMeClassParameter(this Skola classParam) => classParam.GetMeParameter(5);

	public static int GetMeClassParameter2(Skola classParam) => classParam.GetMeParameter(5);

	public static int Add(this int a, int b) => a + b;

}

public class Skola
{
	int field = 5;
	public int GetMeParameter(int intParam) => intParam * intParam * field;
}