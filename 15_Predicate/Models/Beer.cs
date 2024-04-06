using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Predicate.Models
{
    public class Beer : IBeer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int AlcoholContent { get; set; }
        public double Price { get; set; }
        public static List<Beer> BeerCollection { get; } = new List<Beer>();

        public Beer(string name, string marca, int alcohol, double price)
        {
            Name = name;
            Brand = marca;
            AlcoholContent = alcohol;
            Price = price;

            BeerCollection.Add(this);
        }

        public List<Beer> AlcoholThatICanDrink(List<Beer> beers, Predicate<Beer> condicion)
        {
            List<Beer> filteredBeers = beers.FindAll(condicion);
            //beers.ForEach(b => Console.WriteLine($"The beers that you can drink are: {b.Name}"));
            return filteredBeers;
        }
    }
}
