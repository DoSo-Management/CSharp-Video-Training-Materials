<Query Kind="Program" />

void Main()
{
	var getSet = new GetSet();
	
	getSet.GetSetTester = 5;
	getSet.GetSetTester = 5;
	getSet.GetSetTester = 5;

	getSet.GetSetTester.Dump();
	getSet.Dump();

	getSet.Dump();

	getSet.Dump();
}

class GetSet
{
	int getCounter = 0;
	int setCounter = 0;

	public int GetSetTester
	{
		get => getCounter++.Dump("GET called");
		set => setCounter++.Dump("SET called");
	}	
}