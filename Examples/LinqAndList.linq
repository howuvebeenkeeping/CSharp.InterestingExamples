<Query Kind="Statements" />

var list = new List<string> { "A1", "B1", "B2" };
var filterredList = list.Where(x => x.StartsWith("B"));
list.Remove("B1");
Console.WriteLine(filterredList.Count());

var _list = new List<string> { "A1", "B1", "B2" };
var _filterredList = _list.Where(x => x.StartsWith("B")).ToList();
_list.Remove("B1");
Console.WriteLine(_filterredList.Count());