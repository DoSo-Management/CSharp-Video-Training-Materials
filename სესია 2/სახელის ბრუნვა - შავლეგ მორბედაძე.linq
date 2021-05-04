<Query Kind="Program" />

void Main()
{
	var koka = new Human
	{
		Firstname = "კოკა",
		Lastname = "ხიჯაკაძე",
		DateOfBirth = new DateTime(1992, 3, 18)
	};
	DumpHuman(koka);

	var nika = new Human
	{
		Firstname = "შავლეგ",
		Lastname = "მორბედაძე",
		DateOfBirth = new DateTime(1994, 2, 15)
	};
	nika.GetAge().Dump();
	DumpHuman(nika);
	DumpHuman(nika);
}

class Human
{
	public string Firstname;
	public string Lastname;
	public DateTime DateOfBirth;
	public string Age => $@"{Firstname}{(Firstname.EndsWithVowel() ? "ს" : "ის")} ასაკი არის [{GetAge()}]";
	
	public int GetAge()
	{
		var yearsDiff = DateTime.Now.Year - DateOfBirth.Year;
		var addYears = DateOfBirth.AddYears(yearsDiff);

		return yearsDiff -
			(addYears > DateTime.Now
				? 1
				: 0);
	}
}

static class Ext
{
	public static bool EndsWithVowel(this string str)
	{
		var lastSymbol = str.ToCharArray().Last();
		return new[] {'ა','ე','ი','ო','უ'}.Contains(lastSymbol);
	}
}

void DumpHuman(Human human)
{
	human.Dump(human.Firstname);
}