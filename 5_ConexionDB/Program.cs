

using _5_ConexionDB.Models;

CervezaDB cervezaDB = new CervezaDB();

var cervezas = cervezaDB.Get();

foreach (var cerveza in cervezas)
{
    Console.WriteLine(cerveza.Nombre);
}



