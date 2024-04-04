
class Program
{
    // Delegado normal que define una operación matemática
    public delegate int OperacionMatematica(int x, int y);

    static void Main(string[] args)
    {
        int numero1 = 10;
        int numero2 = 5;

        // Función anónima utilizando el delegado Func
        Func<int, int, int> division = (a, b) => a / b;

        // Llamada a la función que realiza una operación matemática utilizando el delegado normal
        RealizarOperacion(numero1, numero2, Sumar);
        RealizarOperacion(numero1, numero2, Restar);
        RealizarOperacion(numero1, numero2, Multiplicar);
        RealizarOperacion(numero1, numero2, division);

        // Función anónima utilizando el delegado Action
        Action<int, int, Func<int, int, int>> RealizarOperacion2 = (a, b, operacion) =>
        {
            int resultado = operacion(a, b);
            Console.WriteLine($"Resultado de la operación: {resultado}");
        };

        RealizarOperacion2(numero1, numero2, Sumar);

        // Usando el delegate normal
        Action<int, int> pruebaDelegateNormal = (a, b) => Console.WriteLine($"La division pruebaDelegateNormal es: {a / b}");
        pruebaDelegateNormal(5, 2);

        RealizarOperacionDelegateNormal(numero1, numero2, Sumar);

        int number = RealizarOperacionDelegateNormal2(numero1, numero2, Sumar);
        Console.WriteLine($"Number is: {number}");

        int getResult = RealizarOperacionDelegateNorma3(numero1, numero2, (numero1, numero2) => numero1 + numero2);
        Console.WriteLine($"getResult is: {getResult}");

        int getResult2 = RealizarOperacionDelegateNorma3(100, 20, (x, y) => division(x, y));
        Console.WriteLine($"getResult2 is: {getResult2}");

    }

    // Método para sumar dos números
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método para restar dos números
    static int Restar(int a, int b)
    {
        return a - b;
    }

    // Método para multiplicar dos números
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static void RealizarOperacion(int a, int b, Func<int, int, int> operacion)
    {
        int resultado = operacion(a, b);
        Console.WriteLine($"Resultado de la operación utilizando delegado normal: {resultado}");
    }

    static void RealizarOperacionDelegateNormal(int a, int b, OperacionMatematica operacion)
    {
        int resultado = operacion(a, b);
        Console.WriteLine($"Resultado de la operación utilizando delegado normal: {resultado}");
    }
    
    static int RealizarOperacionDelegateNormal2(int a, int b, OperacionMatematica operacion)
    {
        int resultado = operacion(a, b);
        return resultado;
    }
    
    static int RealizarOperacionDelegateNorma3(int a, int b, OperacionMatematica operacion)
    {
        int resultado = operacion(a, b);
        return resultado;
    }


}
