

using _15_Predicate.Models;



List<int> numbers = new List<int> { 1, 56, 2, 3, 3, 45, 6 };

//var predicate = new Predicate<int>(IsDivider2);
//bool IsDivider2(int x) => x % 2 == 0;
//var getParNumbers = numbers.FindAll(predicate);
//getParNumbers.ForEach(d => Console.WriteLine(d));//getParNumbers.ForEach(d => Console.WriteLine(d));

// Estableciendo predicate con una funcion anonima.
var predicate = new Predicate<int>(x => x % 2 == 0);
var dividers2 = numbers.FindAll(predicate);

dividers2.ForEach(d => { Console.WriteLine(d); });

////// Otro ejemplo.
Console.WriteLine();
Predicate<int> negativePredicate = new Predicate<int>(x => !predicate(x));
dividers2 = numbers.FindAll(negativePredicate);
dividers2.ForEach(d => { Console.WriteLine(d); });

// Otro ejemplo, esta vez con cervezas.
Console.Write("\nEjemplo predicate de cervezas usando clase:\n\n");

Beer beer1 = new Beer("Stella Artois", "AB InBev", 5, 2.5);
Beer beer2 = new Beer("Heineken", "Heineken International", 8, 3.0);
Beer beer3 = new Beer("Budweiser", "AB InBev", 9, 2.0);
Beer beer4 = new Beer("Corona", "Grupo Modelo", 12, 2.5);

List<Beer> myBeers = Beer.BeerCollection;
foreach (var beer in myBeers)
{
    Console.WriteLine(beer.Name);
}

Console.WriteLine("");

//beer4.AlcoholThatICanDrink(myBeers, b => b.AlcoholContent > 6);

List<Beer> myBeersList = beer1.AlcoholThatICanDrink(myBeers, b => (b.AlcoholContent > 6 && b.AlcoholContent <= 10));
myBeersList.ForEach(b => Console.WriteLine(b.Name));

