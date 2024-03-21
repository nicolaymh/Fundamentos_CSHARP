

namespace _2_Clases_Objetos_Constructores.Models
{
    internal class Cerveza : Bebida
    {
        // Puedo definir parametros por defecto desde el inicio cuando heredo.
        //Constructor:
        //public Cerveza() : base("cerveza", 1000) { }

        // Tambien puedo definir el contructor de esta clase que hereda:
        //public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad) { }

        // Podemos poner parametros por defecto o opcional, pero los que vienen por defecto tienen que ir de ultimas:
        public Cerveza(int Cantidad, string Nombre = "Pilsen")
            : base(Nombre, Cantidad)
        {

        }

    }
}
