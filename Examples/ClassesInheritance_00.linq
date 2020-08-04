<Query Kind="Program" />

void Main()
{
	A a = new A(); 
	a.Foo();            // A
	
	// B b1 = new A();  
	// b1.Foo();		// Compilation Error
	
	A b2 = new B();
	b2.Foo();           // B
	
	A c = new C();
	c.Foo();			// A		
	
	D d = new D();		
	d.Foo();			// D
	
	E e = new E();		
	e.Foo();			// E
}

class A 
{
	public virtual void Foo() => "A".Dump();
}

class B : A
{
	public override void Foo() => "B".Dump();
}

class C : A
{
	public new void Foo() => "C".Dump();
}

class D : A
{
	public void Foo() => "D".Dump();
}

class E : B
{
	public new void Foo() => "E".Dump();
}