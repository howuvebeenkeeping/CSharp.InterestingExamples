<Query Kind="Statements" />

int Test()
{
	try
	{
		return 1;
	}
	finally 
	{
		// нельзя возвращать значения из блока finally (в Java можно)
		return 2; // не скомпилируется
	}
}

Console.WriteLine(Test());