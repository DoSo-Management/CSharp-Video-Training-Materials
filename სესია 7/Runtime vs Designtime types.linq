<Query Kind="Program" />

void Main()
{
	object variable;

	variable = 5;
	variable.GetType().Dump("5");
	variable = "ნიკა დოლიძე";
	variable.GetType().Dump("ნიკა დოლიძე");


	DoNothing(5);
	DoNothing(new Class { Name = "CLS" });

	DoNothing(new object());
}
class Class
{
	public string Name { get; set; }
}

void DoNothing(object x)
{
	if (x is Class xClass) xClass.Name.Dump();
	
	var xAsClass = x as Class;
	if (xAsClass != null) xAsClass.Name.Dump();

	if (x is int xInt) "x was of type int!".Dump();
	(x as Class)?.Name.Dump("-");

	x.Dump();
}