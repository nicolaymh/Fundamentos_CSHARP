

using _2_Clases_Objetos_Constructores.Models;

List<int> numeros = new List<int>() { 1, 4, 5, 6, 7, 2, 3 };

int numero7 = numeros.Where(d => d == 7).FirstOrDefault();
Console.WriteLine(numero7);

var numerosOrdenados = numeros.OrderBy(d => d);
foreach (int numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}

var sumatoria = numeros.Sum(d => d);
Console.WriteLine(sumatoria);

// Podemos hacer uso de Linq con la funcion de extension o con la sintaxis integrada.
List<Cerveza> cervezas = new List<Cerveza>()
{
    new Cerveza(10,"Pale Ale"){ Alcohol=7, Marca="Minerva" },
    new Cerveza(5,"Ticús"){ Alcohol=8, Marca="Colima" },
    new Cerveza(8,"Stout"){ Alcohol=7, Marca="Minerva" },
    new Cerveza(100,"Piedra Lisa"){ Alcohol=6, Marca="Colima" }
};

// Cervezas ordenadas alfabeticamente por marca.
var cervezasOrdenadas = from d in cervezas
                        orderby d.Marca
                        select d;
foreach (Cerveza cerveza in cervezasOrdenadas)
{
    Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
}


// Ordenas por orden alfabetico cervezas de la marca Minerva;
var ordenarCervezasMinerva = from d in cervezas
                             where d.Marca == "Minerva"
                             orderby d.Marca
                             select d;
foreach (Cerveza cerveza in ordenarCervezasMinerva)
{
    Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
}
