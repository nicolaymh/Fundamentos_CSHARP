using _2_Clases_Objetos_Constructores.Models;

// Cola (queue) => el primero en la fila es el primero en salir.
// Pila (stack) => el último en la fila es el primero en salir.

// Array

//int[] numeros = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Definiando longitud del array desde el comienzo.

int[] numeros = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]; // Definiando longitud del array desde el comienzo.

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Iteración {i} - {numeros[i]}");
}

Console.WriteLine("\n");

foreach (int numero in numeros)
{
    Console.WriteLine($"Iteración {numero} - {numeros[numero]}");
}

Console.WriteLine("\n************************************************************************");
// Las lista es una clase de C# que implementan regularmente una interfaz. Los arreglos siempre van a ser mas rapido que una lista ya que esta orientado a una coleccion de objetos. 

List<int> lista = new List<int>();

List<int> lista2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
lista2.Add(9);
lista2.Add(0);
lista2.Remove(2);

foreach (int numero in lista2)
{
    Console.WriteLine(numero);
}

Console.WriteLine("\n************************************************************************");

// Tambien puedo crear una lista de una clase.
// Formas de crear el objeto para agregarlo a lista clase Cerveza:
List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Premium") };
cervezas.Add(new Cerveza(500));
Cerveza erdinger = new Cerveza(400, "Trigo");
cervezas.Add(erdinger);

foreach (var cerveza in cervezas)
{
    Console.WriteLine($" Cerveza: {cerveza.Nombre} | Cantidad: {cerveza.Cantidad}");
}