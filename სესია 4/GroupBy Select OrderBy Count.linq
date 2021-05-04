<Query Kind="Program" />

void Main()
{
	var path = @"C:\Users\Petre\Downloads";

	// Select, Count, GroupBy, OrderBy, Where, OrderByDescending, Sum

	var allFilesInPath = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

	var filesGroupedByExtension = allFilesInPath
		.GroupBy(file => Path.GetExtension(file))
		.Where(ext => ext.Key.Length != 4)
		.Select(group => new { group.Key, Count = group.Count()})
		.OrderByDescending(k => k.Count)
		.Dump()
		;
}

