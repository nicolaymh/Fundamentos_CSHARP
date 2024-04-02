using _2_Clases_Objetos_Constructores.Models;


namespace _12_Linq.Models
{
    public class BarData
    {
        public string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarData(string Nombre)
        {
            this.Nombre = Nombre;
        }
    
    }
}
