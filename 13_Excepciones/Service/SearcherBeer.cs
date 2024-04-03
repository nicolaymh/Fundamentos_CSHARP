using _13_Excepciones.Errors;
using _2_Clases_Objetos_Constructores.Models;

using System.Linq;


namespace _13_Excepciones.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(10,"Pale Ale"){ Alcohol=7, Marca="Minerva" },
            new Cerveza(5,"Ticús"){ Alcohol=8, Marca="Colima" },
            new Cerveza(8,"Stout"){ Alcohol=7, Marca="Minerva" },
        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                           where d.Nombre == Nombre
                           select d).FirstOrDefault();
            if (cerveza == null)
            {
                throw new BeerNotFoundException("La cerveza se ha terminado");
            }

            return cerveza.Cantidad;
        }
    }
}
