<Query Kind="Program" />

void Main()
{
	var x = new
	{
		სახელი = "ირინკა",
		გვარი = "ლაკოევი"
	}.Dump();
	
	//var x = (სახელი :"ირინკა", გვარი: "ლაკოევი").Dump(); //-- tuple 
	
	x.სახელი.Dump();
	
	//x.სახელი.Dump();
}