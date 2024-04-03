

using _2_Clases_Objetos_Constructores.Models;

namespace _12_Linq.Models
{
    internal class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> Cervezas = new List<Cerveza>();

        public Bar(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
