<Query Kind="Program" />

void Main()
{
	var path = @"C:\Users\Petre\Downloads";

	var allTxtFiles = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories)
		.Select(f => new { f, content = File.ReadAllText(f) })
		.Take(10)
		.Dump()
		;
}