// Linq para manipular y obtener objetos complejos con subconsultas.

using _12_Linq.Models;
using _2_Clases_Objetos_Constructores.Models;

List<Bar> bares = new List<Bar>()
{
   new Bar("El bar")
   {
       Cervezas = new List<Cerveza>()
       {
           new Cerveza(10,"Pale Ale"){ Alcohol=7, Marca="Minerva" },
           new Cerveza(5,"Ticús"){ Alcohol=8, Marca="Colima" },
           new Cerveza(8,"Stout"){ Alcohol=7, Marca="Minerva" },
       }
   },
   new Bar("El bar 2")
   {
       Cervezas = new List<Cerveza>()
       {
            new Cerveza(8,"Stout"){ Alcohol=7, Marca="Minerva" },
            new Cerveza(100,"Piedra Lisa"){ Alcohol=6, Marca="Colima" }
       }
   },
   new Bar("El bar nuevo")
};

List<Cerveza> cervezas = new List<Cerveza>()
{
    new Cerveza(10,"Pale Ale"){ Alcohol=7, Marca="Minerva" },
    new Cerveza(5,"Ticús"){ Alcohol=8, Marca="Colima" },
    new Cerveza(8,"Stout"){ Alcohol=7, Marca="Minerva" },
    new Cerveza(100,"Piedra Lisa"){ Alcohol=6, Marca="Colima" }
};

// Buscando bar que tenga la cerveza Ticús:
//Bar? bar = (from d in bares
//            from c in cervezas
//            where c.Nombre == "Ticús"
//            select d).FirstOrDefault();

// Otra forma:
//var bar = (from d in bares
//          where d.Cervezas.Where(c => c.Nombre == "Stout").Count() > 0
//          select d).ToList();

// Quizas no me interese obtener todo el objeto completo, podria usar otra clase solo para obtener los datos que me interesan:
var bar = (from d in bares
           where d.Cervezas.Where(c => c.Nombre == "Stout").Count() > 0
           select new BarData(d.Nombre)
           {
               bebidas = (from c in d.Cervezas
                          select new Bebida(c.Nombre, c.Cantidad)
                         ).ToList()
           }
           ).ToList();


Console.WriteLine(bar);


