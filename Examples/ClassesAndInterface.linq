<Query Kind="Program" />

void Main()
{
	Show();
}

void Show() 
{
	A a = new A(), b = new B(), c = new C();
	I ia = new A(), ib = new B(), ic = new C();
	A ac = new C(); B bc = new C();
	Console.WriteLine($"{a.P}, {b.P}, {c.P}, {ia.P}, {ib.P}, {ic.P}"); // 0, 1, 1, 0, 1, 2
	Console.WriteLine($"{ac.P}, {bc.P}"); 							   // 1, 1
}

interface I
{
	int P { get; }
}

class A : I 
{
	public virtual int P => 0;
}

class B : A
{
	public override int P => 1;
}

class C : B, I
{
	public int P => 2;
}