<Query Kind="Program" />

void Main()
{
	var cadCodes = new[]
	{
		CadCode.From("11E01C"),
		CadCode.From("11E01"),
		CadCode.From("23E01"),
		CadCode.From("26O19"),
		CadCode.From("2D02I"),
		CadCode.From("26C01"),
		CadCode.From("12E01"),
		CadCode.From("26A08"),
		CadCode.From("53B04"),
		CadCode.From("14C01"),
		CadCode.From("26O19"),
		CadCode.From("2D02I"),
		CadCode.From("26C01"),
		CadCode.From("12E01"),
		CadCode.From("26A08"),
		CadCode.From("2D02I"),
		CadCode.From("11E01"),
		CadCode.From("26O19"),
		CadCode.From("2D01 "),
		CadCode.From("3D11 "),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("26A08"),
		CadCode.From("2D02I"),
		CadCode.From("11E01"),
		CadCode.From("26O19"),
		CadCode.From("14C01"),
		CadCode.From("26C01"),
	}.ToList();

	cadCodes
		.OrderByDescending(c => c)
		.Dump();
}

public class CadCode : IComparable<CadCode>
{
	public CadCode(string value) => Value = value.Trim();
	public int CompareTo(CadCode cadCode) => (int)ProQaCodesSortingUtilities.Compare(Value, cadCode.Value);

	public static CadCode From(string value) => new(value);
	public string Value { get; }
}

public static class ProQaCodesSortingUtilities
{
	private static string[] SplitCadCode(string cadCode)
	{
		if (string.IsNullOrWhiteSpace(cadCode))
		{
			return null;
		}

		var formattedCode = cadCode.Contains(' ') ? cadCode.Split(' ')[0] : cadCode;
		try
		{
			var letter = formattedCode.ToCharArray().FirstOrDefault(char.IsLetter);
			var indexOfLetter = formattedCode.IndexOf(letter);
			var dispatchLetter = formattedCode[indexOfLetter].ToString();
			var dispatchNumberWithPossibleSuffix = formattedCode.Substring(indexOfLetter + 1);
			var dispatchNumber = dispatchNumberWithPossibleSuffix.ToCharArray().Any(char.IsLetter)
				? dispatchNumberWithPossibleSuffix.Substring(0, dispatchNumberWithPossibleSuffix.Length - 1)
				: dispatchNumberWithPossibleSuffix;
			return new[] { dispatchLetter, dispatchNumber };
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static int GetLetterAsNumber(char lt)
	{
		return char.ToUpper(lt) switch
		{
			'O' => 1,
			'A' => 2,
			'B' => 3,
			'C' => 4,
			'D' => 5,
			'E' => 6,
			_ => 100
		};
	}

	private static int CompareCore(string code1, string code2)
	{
		var val1 = SplitCadCode(code1);
		var val2 = SplitCadCode(code2);
		if ((code1 == null) || (code2 == null))
			return default;
		var number1 = int.Parse(val1[1]);
		var number2 = int.Parse(val2[1]);
		var letterAsNumber1 = GetLetterAsNumber(val1[0][0]);
		var letterAsNumber2 = GetLetterAsNumber(val2[0][0]);
		static int CompareCodes(int firstCode, int secondCode, int firstNumber, int secondNumber) =>
			firstCode > secondCode
				? -1
				: (firstCode < secondCode
					? 1
					: (firstNumber > secondNumber
						? 1
						: (firstNumber < secondNumber
							? -1
							: 0)));
		return CompareCodes(letterAsNumber1, letterAsNumber2, number1, number2);
	}

	public enum ComparisonEnum
	{
		IsEqual = 0,
		FirstIsGreater = 1,
		SecondIsGreater = -1
	}

	public static ComparisonEnum Compare(string code1, string code2) =>
		CompareCore(code1, code2)
			switch
		{
			0 => ComparisonEnum.IsEqual,
			1 => ComparisonEnum.SecondIsGreater,
			-1 => ComparisonEnum.FirstIsGreater,
			var anyOtherValue => throw new InvalidOperationException($"[{anyOtherValue}] is not a valid result")
		};
}