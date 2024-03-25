

using _2_Clases_Objetos_Constructores.Models;
using _5_ConexionDB.Models;


// Crear y insertar una cerveza en la DB.
{
    //Cerveza cerveza = new(15, "Pale ale")
    //{
    //    Alcohol = 6,
    //    Marca = "Minerva"
    //};
    //CervezaDB addCervezaDB = new CervezaDB();
    //addCervezaDB.Add(cerveza);
}

Console.WriteLine("\n");

// Actualizar una cerveza de la DB.
{
    //Cerveza cerveza = new(10, "Aguila")
    //{
    //    Alcohol = 4,
    //    Marca = "Bavaria"
    //};
    //CervezaDB updateCervezaDB = new CervezaDB();
    //updateCervezaDB.Edit(cerveza, 6);
}

Console.WriteLine("\n");

// Eliminar una cerveza de la DB.
{
    CervezaDB deleteCervezaDB = new CervezaDB();
    deleteCervezaDB.Delete(8);
}

Console.WriteLine("\n");

// Obtener todas las cervezas de la DB.
{
    CervezaDB cervezaDB = new CervezaDB();
    List<Cerveza> cervezas = cervezaDB.Get();
    foreach (Cerveza cerveza in cervezas)
    {
        Console.WriteLine(cerveza.Nombre);
    }
}