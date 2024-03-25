

using Interfaces.Models;

namespace _2_Clases_Objetos_Constructores.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }

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
