<Query Kind="Statements" />

string s1 = "strasse";
string s2 =  "straße";
Console.WriteLine($"{s1.Length} {s2.Length}");
Console.WriteLine(s1 == s2);
Console.WriteLine(s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));