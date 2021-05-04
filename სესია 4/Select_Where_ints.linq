<Query Kind="Program" />

void Main()
{
	var intArray
		= Enumerable.Range(1, 100);

	var intArraySummed = intArray
		.Select(i => new
		{
			i,
			ჯამი = i + i,
			mod2 = i % 3
		})
		.Where(i => i.mod2 == 0)
		.Dump();

	intArraySummed
		.Where(i => i.mod2 == 0)
		.Dump();
		
	intArray.Count().Dump("count");
}