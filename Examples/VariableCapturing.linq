<Query Kind="Statements" />

var actions = new List<Action>();
for (int i = 1; i <= 3; i++)
	actions.Add(() => Console.WriteLine(i));

foreach (var action in actions)
	action();
