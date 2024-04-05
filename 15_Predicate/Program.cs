

var numbers = new List<int> { 1, 56, 2, 3, 3, 45, 6 };

//var predicate = new Predicate<int>(IsDivider2);
//bool IsDivider2(int x) => x % 2 == 0;

// Estableciendo predicate con una funcion anonima.
var predicate = new Predicate<int>(x => x % 2 == 0);
var dividers2 = numbers.FindAll(predicate);

dividers2.ForEach(d => { Console.WriteLine(d); });

// Otro ejemplo.
Console.WriteLine();
Predicate<int> negativepRedicate = new Predicate<int>(x => !predicate(x));
dividers2 = numbers.FindAll(negativepRedicate);
dividers2.ForEach(d => { Console.WriteLine(d); });

// Otro ejemplo, esta vez con cervezas.
