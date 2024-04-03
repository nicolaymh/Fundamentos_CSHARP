
using _13_Excepciones.Errors;
using _13_Excepciones.Service;

try
{
    var SearcherBeer = new SearcherBeer();
    var cantidad = SearcherBeer.GetCantidad("Stouts");
    Console.WriteLine("Todo bien");
}
catch (FieldAccessException)
{
    Console.WriteLine("Si te ha cachado");
}
catch (BeerNotFoundException ex)
{
    Console.WriteLine($"BeerNotFound {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Esto siempre se ejecuta");
}