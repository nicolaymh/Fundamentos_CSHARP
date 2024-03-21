using _2_Clases_Objetos_Constructores.Models;


// Creando instancia de una clase:
var bebida = new Bebida( "Coca cola", 1000 );
bebida.Beberse(500);
Console.WriteLine(bebida.Cantidad);

// Usando la clase Cerveza que hereda de Bebida:
//var cerveza = new Cerveza("Aguila", 800);
var cerveza = new Cerveza(1500, "Poker");

cerveza.Beberse(250);
Console.WriteLine(cerveza.Cantidad);