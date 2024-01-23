
List<int> list = new List<int>() {2, 9, 3, 8, 1, 7, 4, 6, 5, 10 };

List<int> listG = new List<int>();

foreach (var i in list)
{
	if (i % 2 == 0)
		listG.Add(i);
}

foreach (var i in listG)
{
	Console.Write($" {i} ");
}

//-----------------------------------------------------------------------

var listErg = list.FindAll(x => x % 2 == 0);
Console.WriteLine();
foreach (var i in listErg.OrderBy(x=>x))
{
	Console.Write($" {i} ");

}

Console.WriteLine();
foreach (var i in listErg.OrderBy(x => x % 2 == 0))
{
	Console.Write($" {i} ");

}

Console.WriteLine();
foreach (var i in listErg.OrderByDescending(x => x % 2 == 0))
{
	Console.Write($" {i} ");

}

Console.WriteLine("\n");

List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

//var square = numbers.Select(x => x * x);

foreach(var n in numbers.Select(x => x * x))
{
	Console.Write($"\t{n}");
}

Console.WriteLine();

foreach (var n in numbers.FindAll(x => (x%3) == 0))
{
	Console.Write($"\t{n}");
}



Console.ReadKey();