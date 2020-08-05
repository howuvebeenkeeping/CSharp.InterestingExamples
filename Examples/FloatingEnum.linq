<Query Kind="Program" />

enum MyEnum { Hello, Hola };

void Main()
{
	MyEnum f0 = 0.0f;
	Console.WriteLine(f0);
	
	MyEnum f1 = 1.0f; // не скомпилируется
	Console.WriteLine(f1);
	
	// странное поведение компилятора
}