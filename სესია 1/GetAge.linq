<Query Kind="Program" />

void Main()
{
	//GetAge(DateTime.Now).Dump();
	GetAge(new DateTime(1998, 7, 4)).Dump();
	GetAge(DateTime.Now.AddYears(-5).AddMonths(-1).Dump()).Dump();
	GetAge(DateTime.Now.AddYears(-5).AddMonths(1).Dump()).Dump();

	//GetAge(new DateTime(1992, 3, 18)).Dump();
	//GetAge(new DateTime(1992, 3, 18)).Dump();
}

int Sum(int a, int b)
{
	return a + b;
}

int GetAge(DateTime dateOfBirth)
{
	var yearsDiff = DateTime.Now.Year - dateOfBirth.Year;
	var addYears = dateOfBirth.AddYears(yearsDiff);

	//return addYears > DateTime.Now
	//	? yearsDiff - 1
	//	: yearsDiff;
	//	
	//if (addYears > DateTime.Now)
	//	return yearsDiff - 1;
	
	//return yearsDiff;

	return yearsDiff -
		(addYears > DateTime.Now
			? 1
			: 0);
}