

using _10_Generics.Models;
using Interfaces.Models;

namespace _2_Clases_Objetos_Constructores.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica, IRequestable
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }

        public int id { get; set; }

        public Cerveza(int Cantidad, string Nombre = "Pilsen")
            : base(Nombre, Cantidad)
        {

        }


        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10");
        }
    }
}
