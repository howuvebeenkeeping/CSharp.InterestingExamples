<Query Kind="Program" />

void Main()
{
	Show();
	// Static constructor B called
	// Static constructor A called
	// Constructor A called
	// B value = 0
	// Constructor B called
}

public void Show()
{
	A a = new B();
}

public class A 
{
	public A() 
	{
		Console.WriteLine("Constructor A called");
		Console.WriteLine($"B.value = {B.value}");
	}
	static A() 
	{
		Console.WriteLine("Static constructor A called");
	}
}

public class B : A
{
	public B() => Console.WriteLine("Constructor B called");
	static B()
	{
		value = 0;
		Console.WriteLine("Static constructor B called");
	}
	public static int value = 1;
}