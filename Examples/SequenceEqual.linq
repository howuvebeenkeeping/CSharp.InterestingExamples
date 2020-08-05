<Query Kind="Statements" />

var sequenceA0 = new[] { 1, 2 };
var sequenceB0 = new[] { 1, 2 };
Console.WriteLine(sequenceA0 == sequenceB0); // False
Console.WriteLine(sequenceA0.SequenceEqual(sequenceB0)); // True

var sequenceA1 = new[] { 2, 1 };
var sequenceB1 = new[] { 1, 2 };
Console.WriteLine(sequenceA1 == sequenceB1); // False
Console.WriteLine(sequenceA1.SequenceEqual(sequenceB1)); // False

var sequenceA2 = new int[] { };
var sequenceB2 = new int[] { };
Console.WriteLine(sequenceA2 == sequenceB2); // False
Console.WriteLine(sequenceA2.SequenceEqual(sequenceB2)); // True



