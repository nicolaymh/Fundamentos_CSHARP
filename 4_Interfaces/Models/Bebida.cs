

namespace _2_Clases_Objetos_Constructores.Models
{
    internal class Bebida
    {
        // Propiedades:
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        // Constructor:
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        // Metodo:
        public void Beberse(int CuantoBebio)
        {
            Cantidad -= CuantoBebio;
        }
    }
}
