<Query Kind="Statements" />

IEnumerable<string> Foo() 
{
	yield return "1";
	yield return "2";
	// yield break;     // prints 1 2
	Console.WriteLine("3");
}

foreach (var s in Foo())
{
	Console.WriteLine(s);  // 1 2 3
}