<Query Kind="Program" />

void Main()
{
	// суммирует, но непонятно по какому принципу
	var str = "V1,V2,V3";
	if (Enum.TryParse(str, out MyEnum result)) 
	{
		Console.WriteLine(result); 
		
	}
	else 
	{
		Console.WriteLine("Parse error");	
	}
}

enum MyEnum
{
	V1, V2, V3, V4, V5
}
