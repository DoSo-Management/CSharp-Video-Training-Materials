<Query Kind="Program" />

void Main()
{
	//DateTime.Now.ToString("m").Dump();
	//return;
	//
	//default(int?).Dump();
	//return;

	var firstJanOfCurrentYearMinus1 = new DateTime(DateTime.Now.Year, 1, 1).AddDays(-1);
	var firstJanOfNextYearMinus1 = firstJanOfCurrentYearMinus1.AddYears(1);
	var daysCountInCurrentYear = (firstJanOfNextYearMinus1 - firstJanOfCurrentYearMinus1).Days.Dump();

	var allDatesInCurrentYear = Enumerable
		.Range(1, daysCountInCurrentYear)
		.Select(i => new { i, date = firstJanOfCurrentYearMinus1.AddDays(i).FormatDate() })
		.ToList()
		;

	allDatesInCurrentYear
		.Select(i => new
		{
			i,
			second = allDatesInCurrentYear
				.Single(s => s.i + i.i == daysCountInCurrentYear + 1)
		})
		.Select(s => new
		{
			s.i.i,
			s.i.date,
			secondi = s.second.i,
			seconddate = s.second.date
		})
		.Dump();
}

public static class Extensions
{
	public static string FormatDate(this DateTime dateTime) => dateTime.ToString("yyyy-MMM-dd");
}