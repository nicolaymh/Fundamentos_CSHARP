namespace Tipos_Datos_Var
{
    class Program
    {

        static void Main(string[] args)
        {
            // Tipo de dato byte (rango: 0 a 255)
            byte byteValue = 10; // Ejemplo de uso: Almacenamiento de la edad de una persona en años.

            // Tipo de dato sbyte (rango: -128 a 127)
            sbyte sbyteValue = -5; // Ejemplo de uso: Representación del nivel de temperatura en grados Celsius.

            // Tipo de dato short (rango: -32,768 a 32,767)
            short shortValue = -1000; // Ejemplo de uso: Almacenamiento de la distancia en metros.

            // Tipo de dato ushort (rango: 0 a 65,535)
            ushort ushortValue = 5000; // Ejemplo de uso: Representación de la cantidad de elementos en una lista.

            // Tipo de dato int (rango: -2,147,483,648 a 2,147,483,647)
            int intValue = -100000; // Ejemplo de uso: Almacenamiento del saldo de una cuenta bancaria.

            // Tipo de dato uint (rango: 0 a 4,294,967,295)
            uint uintValue = 200000; // Ejemplo de uso: Representación de la cantidad de productos en inventario.

            // Tipo de dato long (rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807)
            long longValue = -1000000000; // Ejemplo de uso: Almacenamiento del número de teléfono como identificador único.

            // Tipo de dato ulong (rango: 0 a 18,446,744,073,709,551,615)
            ulong ulongValue = 2000000000; // Ejemplo de uso: Representación del espacio de almacenamiento disponible en bytes.

            // Tipo de dato float (rango: -3.402823e38 a 3.402823e38)
            float floatValue = 3.14f; // Ejemplo de uso: Representación de un número decimal de precisión simple.

            // Tipo de dato double (rango: -1.79769313486232e308 a 1.79769313486232e308)
            double doubleValue = 3.14159; // Ejemplo de uso: Representación de un número decimal de precisión doble.

            // Tipo de dato decimal (rango: ±1.0 × 10^-28 a ±7.9 × 10^28 con 28-29 dígitos de precisión)
            decimal decimalValue = 1000.50m; // Ejemplo de uso: Representación de valores monetarios con alta precisión.

            // Tipo de dato char(rango: Unicode, que abarca desde U + 0000 hasta U + FFFF)
            char charValue = 'A'; // Ejemplo de uso: Almacenamiento de un carácter ASCII en una variable.

            // Tipo de dato string (cadenas de caracteres)
            string stringValue = "Hola, mundo!"; // Ejemplo de uso: Almacenamiento de texto.

            // Tipo de dato DateTime (representa fechas y horas)
            DateTime dateTimeValue = DateTime.Now; // Ejemplo de uso: Obtener la fecha y hora actual.
            DateTime? nullableDateTime = null; // Ejemplo de uso: Asignar un valor nulo.
            // Método de DateTime para formatear la fecha y hora
            var formattedDateTime = dateTimeValue.ToString("dd/MM/yyyy HH:mm:ss");

            // Tipo de dato bool (valores booleanos)
            bool boolValue = true; // Ejemplo de uso: Almacenamiento de valores de verdadero/falso.

            // Uso de 'var' para inferir automáticamente el tipo de dato (solo para un tipo de dato)
            var saludo = "Hola, mundo!"; // Ejemplo de uso: Almacenamiento de texto.

            // Creación de un objeto de forma explícita
            object persona = new object(); // Ejemplo de uso: Creación de una instancia de un objeto genérico.
            object persona1 = new { nombre = "Nicolay", apellido = "Morneo", edad = 36 }; // Haciendolo asi, no puedo acceder a la propiedades.
            var persona2= new { nombre = "Nicolay", apellido = "Moreno", edad = 36 }; // Haciendolo asi, si puedo acceder a la propiedades.
           

            // Mostrar los valores
            Console.WriteLine("Valores:");
            Console.WriteLine(byteValue);
            Console.WriteLine(sbyteValue);
            Console.WriteLine(shortValue);
            Console.WriteLine(ushortValue);
            Console.WriteLine(intValue);
            Console.WriteLine(uintValue);
            Console.WriteLine(longValue);
            Console.WriteLine(ulongValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine(charValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(formattedDateTime); // Mostrar la fecha y hora formateada
            Console.WriteLine(nullableDateTime); // Mostrar la fecha y hora formateada
            Console.WriteLine(boolValue);
            Console.WriteLine(saludo);
            Console.WriteLine(persona);
            Console.WriteLine(persona1);
            Console.WriteLine(persona2);
            Console.WriteLine(persona2.nombre + " " + persona2.apellido + " " + persona2.edad);
            Console.WriteLine($"{persona2.nombre} {persona2.apellido} {persona2.edad}");
            Console.WriteLine(String.Format("{0} {1} {2}", persona2.nombre, persona2.apellido, persona2.edad));
        }
    }
}
