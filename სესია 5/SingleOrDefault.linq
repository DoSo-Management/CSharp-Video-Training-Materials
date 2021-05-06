<Query Kind="Program" />

void Main()
{
	var ints = Enumerable.Range(1,10).Dump();
	
	ints.SingleOrDefault(i => i > 50).Dump();
}

// You can define other methods, fields, classes and namespaces here
