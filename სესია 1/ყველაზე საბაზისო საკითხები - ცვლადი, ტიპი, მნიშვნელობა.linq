<Query Kind="Program" />

void Main()
{
	string stringVariable = "გამარჯობა!";
	stringVariable.Dump("პირველი");
	stringVariable = "კოკა";
	stringVariable.Dump("მეორე");
	stringVariable = 5.ToString();
	
	var implicitlyTypedVariable = "გამარჯობა!";
	
	string unknownVariable;
	unknownVariable = "123";

	var x = 5;
	//x = "5"; // არ იმუშავებს
		
	int intVariable = 5;
	decimal decimalVariable = 5m;
	DateTime dateTimeVariable = DateTime.Now;
	bool boolVariable = true;
	char charVariable = 'a';
}