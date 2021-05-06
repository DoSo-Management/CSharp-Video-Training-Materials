<Query Kind="Program" />

void Main()
{
	var path = @"C:\Users\Petre\Downloads";

	// Select, Count, GroupBy, OrderBy, Where, OrderByDescending, Sum
	// Any, All

	var allFilesInPath = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

	const string twoEnters = "\r\n\r\n";
	var filesGroupedByExtension = allFilesInPath
		.Take(5)
		.Select(f => new
		{
			Original = f.ReadAllText(),
			Ordered = f.ReadAllText()
						.Split(twoEnters)
						//.Select(t => t, t.Length})
						.OrderByDescending(t => t.Length)
						.StringJoin(twoEnters)
		})
		//.Where(file => Path.GetExtension(file) == )
		//.Skip(2)
		//.Take(3)
		//.IsEmpty()
		//.All(ext => ext.Key.Length != 40)
		//.Select(group => new { group.Key, Count = group.Count() })
		//.OrderByDescending(k => k.Count)
		.Dump();
}

public static class Extensions
{
	public static bool IsEmpty<AnyType>(this IEnumerable<AnyType> items)
		=> !items.Any();

	public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

	public static string StringJoin(this IEnumerable<string> strings, string joinWith)
		=> string.Join(joinWith, strings);
		
	public static string ReadAllText(this string path) => File.ReadAllText(path);
}