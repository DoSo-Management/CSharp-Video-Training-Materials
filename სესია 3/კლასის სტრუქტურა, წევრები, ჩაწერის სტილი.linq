<Query Kind="Program" />

void Main()
{
	var luka = new Human("ლუკა").Dump();
	luka.UpdateFirstname("ლუი");
	
	luka.Dump();
}

class Human
{
	// უპარამეტრო კონსტრუქტორი
	public Human()
	{

	}
	// პარამეტრიანი კონსტრუქტორი
	public Human(string firstname)
	{
		_firstname = firstname;
		Firstname = firstname;

		FirstnameMutablePrivately = firstname;
		FirstnameMutablePublicly = firstname;
	}

	public void UpdateFirstname(string firstname)
	{
		// ვერ მოხდება
		//_firstname = firstname;
		//Firstname = firstname;

		FirstnameMutablePrivately = firstname;
		FirstnameMutablePublicly = firstname;
	}

	readonly string _firstname;
	public string Firstname { get; }
	public string FirstnameMutablePrivately { get; private set; }
	public string FirstnameMutablePublicly { get; set; }

	public string FirstNameReturningOtherPropertyValue => Firstname;
	public string FirstNameReturningOtherPropertyValue2
	{
		get => Firstname;
	}

	public string FirstNameReturningOtherFieldValue => _firstname;

	public string Firstname2
	{
		get => FirstnameMutablePrivately;
		set => FirstnameMutablePrivately = value;
	}

	public string StringReturningMethod()
	{
		return Firstname;
	}

	public string StringReturningMethodV2() => Firstname;

	public void FirstnameMutablePrivatelySetter(string firstname)
	{
		FirstnameMutablePrivately = firstname;
	}
	public void FirstnameMutablePrivatelySetter(string firstname, string lastname)
	{
		FirstnameMutablePrivately = firstname + " " + lastname;
	}
}