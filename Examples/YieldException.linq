<Query Kind="Program" />

void Main()
{
	var raw = GetRawData();
	var nums = raw.Take(2).Select(x => x * 2); // лень: Take не выполнится, Select не выполнится
	Console.WriteLine(nums.FirstOrDefault());  // вернет 2
	// если зафиксировать проекцию при помощи ToList(), то получим Exception
}

IEnumerable<int> GetRawData()
{
	yield return 1;
	throw new Exception();
	yield return 2;
}



