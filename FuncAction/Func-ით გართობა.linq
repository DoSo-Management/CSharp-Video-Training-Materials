<Query Kind="Program" />

void Main()
{
	SomeMethod(s => () => () => s);
}

public void SomeMethod(Func<string, Func<Func<string>>> random)
{
	var result = random("logThis");
	result()().Dump();
	//action(() => {});
}

public void SomeMethod2(Func<string, Func<Action>> random)
{
	var result = random("logThis");
	result()();
	//action(() => {});
}