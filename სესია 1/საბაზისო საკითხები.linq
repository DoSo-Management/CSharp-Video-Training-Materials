<Query Kind="Program" />

void Main()
{
	var tamar = new Human
	{
		DateOfBirthP = new DateTime(1998, 7, 4),
		//LastnameP = "test"
	};
	//tamar.FirstnameP = "tamar";
	tamar.SetFirstname("tamar");
	tamar.SetLastname("mtchedlishvili");
	tamar.Dump("tamar");

	var irinka = new Human
	{
		//LastnameP = "lakoevi"
	};
	
	irinka.SetFirstname("irinka");
	irinka.SetLastname("lakoevi");
	irinka.Dump("irinka");

	
	//default(string).Dump();
	//default(int).Dump();
	//default(DateTime).Dump();

}

class Human
{
	//// Fields
	//public string Firstname;
	//public string Lastname;
	//public DateTime DateOfBirth;

	// Property
	public string FirstnameP { get; private set; }
	public string LastnameP { get; private set; }
	public DateTime DateOfBirthP { get; set; }
	
	public void SetFirstname(string fname)
	{
		FirstnameP = fname;
	}

	public void SetLastname(string lname)
	{
		LastnameP = lname;
	}
}