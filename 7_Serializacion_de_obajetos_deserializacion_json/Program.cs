
using System.Text.Json;
using _2_Clases_Objetos_Constructores.Models;


// Convertir en Json. (Serializacion).
Cerveza cerveza = new Cerveza(10, "Cerveza")
{
    Alcohol = 5,
    Marca = "Cualquiera"
};
string miJson = JsonSerializer.Serialize(cerveza);
Console.WriteLine(miJson);

// (Deserializacion de un Json).
//File.WriteAllText("objeto.txt", miJson);
string myJson = File.ReadAllText("objeto.txt");
Cerveza cerveza1 = JsonSerializer.Deserialize<Cerveza>(myJson);
Console.WriteLine(cerveza1.Nombre);