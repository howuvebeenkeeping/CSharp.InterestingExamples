<Query Kind="Program" />

void Main()
{
	A ab = new B();
	A ac = new C();
	Console.WriteLine(ab.Calc() + ac.Calc());
	// 20 * 20 + 30 * 20 = 1000
}

class A
{
	public virtual int Calc() => 10 * Gen();
	protected int Gen() => 10;
}

class B : A
{
	public override int Calc() => 20 * Gen();
	protected int Gen() => 20;
}

class C : B
{
	public override int Calc() => 30 * Gen();
	protected int Gen() => base.Gen();
}
