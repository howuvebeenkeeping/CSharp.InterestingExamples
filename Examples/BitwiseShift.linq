<Query Kind="Statements" />

int i = 1 << 1;
int j;
checked 
{
	j = 1 << 33; // нет переполнения
	j <<= 65;
}
Console.WriteLine($"i:{i}, j:{j}"); // i:2, j:4