
using _8_Solicitudes_serviciosWeb_por_HTTP_Get.Models;
using System.Text.Json;

/////////////////////////////////////
///Desde aqui se instancia la clase. 
await Solicitud.GetInfo();//////////
////////////////////////////////////





public class Solicitud
{
    public static async Task GetInfo()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";

        HttpClient client = new HttpClient();

        var httpResponse = await client.GetAsync(url);

        if (httpResponse.IsSuccessStatusCode)
        {
            string content = await httpResponse.Content.ReadAsStringAsync();

            List<Post>? posts = JsonSerializer.Deserialize<List<Post>>(content);

            foreach (Post post in posts)
            {
                Console.WriteLine($"UserID: {post.userId}");
                Console.WriteLine($"ID: {post.id}");
                Console.WriteLine($"Title: {post.title}");
                Console.WriteLine($"Body: {post.body}");
                Console.WriteLine();
            }

            int cantidadObjetos = posts.Count;
            Console.WriteLine($"La lista contiene {cantidadObjetos} objetos.");
        }

        else
        {
            Console.WriteLine("Hubo un error");
        }
    }

}



