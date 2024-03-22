

using _2_Clases_Objetos_Constructores.Models;

namespace Interfaces.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set;}

        public Vino(string Nombre, int Cantidad) : base(Nombre, Cantidad) 
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 3 copas");
        }
    }
}
