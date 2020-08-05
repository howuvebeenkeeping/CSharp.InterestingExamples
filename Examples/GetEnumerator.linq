<Query Kind="Statements" />

var i = new 
{
	Items = new List<int> { 1, 2, 3 }.GetEnumerator()	
};

while (i.Items.MoveNext())
{
	Console.WriteLine(i.Items.Current);  // infinite prints zero
}

var enumerator = i.Items;
while(enumerator.MoveNext()) 
{
	Console.WriteLine(enumerator.Current);
}

// итератор List<T> оптимизирован - он сделан в виде структуры
// вызывая i.Items мы получаем копию этой самой структуры 
// и каждый раз теребим копию енумератора
