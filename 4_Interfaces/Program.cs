// Interfaz: Podemos verlo como un club al cual si quieres pertenecer a este club, tenemos que respetar ciertas normas.
// El problema radica que yo no puedo hacer multiherencia, esto se puede resolver con una interfaz.
// Los nombres de interfaz tienen que comenzar con una I al comienzo por convencion. Ejemplo: IBebidaAlcoholica.
// Puedo tener mas de una interfaz a sociada a mi clase.
// En C# se pueden poner atributos en las interfaces.
// A partir de C# version 7 para atras los metodos no se podian implementar en las interfaces. A partir de C# version 8 ya se puede... es decir se podía especificar el metodo pero no lo que hace ese metodo.



using _2_Clases_Objetos_Constructores.Models;
using Interfaces.Models;

//var bebidaAlcoholica = new Vino("Te", 100);
//var bebidaAlcoholica2 = new Cerveza(200);
//bebidaAlcoholica.MaxRecomendado();
//bebidaAlcoholica2.MaxRecomendado();

internal class Program
{
    static void Main(string[] args)
    {
        var bebidaAlcoholica = new Vino("Mojito", 100);
        var bebidaAlcoholica2 = new Cerveza(250);
        MostrarRecomendacion(bebidaAlcoholica);
        MostrarRecomendacion(bebidaAlcoholica2);
    }

    static void MostrarRecomendacion(IBebidaAlcoholica bebida)
    {
        bebida.MaxRecomendado();
    }
}