<Query Kind="Statements" />

// "+" вызывает функцию Concat, которая сделает следующее:
// если какая-то из строк null, то будет подставлена пустая строка
var s = (string)null + null;
var isNull = s is null;
Console.WriteLine(isNull);      // False
Console.WriteLine(s is string); // True
