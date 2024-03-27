using _8_Solicitudes_serviciosWeb_por_HTTP_Get.Models;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        // POST.
        //string urlPost = "https://jsonplaceholder.typicode.com/posts/";

        //HttpClient client = new HttpClient();

        //Post post = new Post()
        //{
        //    userId = 50,
        //    body = "Hola como estan",
        //    title = "titulo de saludo"
        //};

        //string dataPut = JsonSerializer.Serialize<Post>(post);
        //HttpContent content = new StringContent(dataPut, System.Text.Encoding.UTF8, "application/json");
        //HttpResponseMessage httpResponse = await client.PostAsync(urlPost, content);

        //if (httpResponse.IsSuccessStatusCode)
        //{
        //    string result = await httpResponse.Content.ReadAsStringAsync();

        //    var postResult = JsonSerializer.Deserialize<Post>(result);
        //}

        // PUT.
        //string urlPut = "https://jsonplaceholder.typicode.com/posts/99";

        //HttpClient client = new HttpClient();

        //Post put = new Post()
        //{
        //    userId = 50,
        //    body = "Hola como estan",
        //    title = "titulo de saludo"
        //};

        //string dataPut = JsonSerializer.Serialize<Post>(put);
        //HttpContent content = new StringContent(dataPut, System.Text.Encoding.UTF8, "application/json");
        //HttpResponseMessage httpResponse = await client.PutAsync(urlPut, content);

        //if (httpResponse.IsSuccessStatusCode)
        //{
        //    string result = await httpResponse.Content.ReadAsStringAsync();

        //    var postResult = JsonSerializer.Deserialize<Post>(result);
        //}

        // DELETE.
        string urlDelete = "https://jsonplaceholder.typicode.com/posts/99";

        var client = new HttpClient();

        var httpResponse = await client.DeleteAsync(urlDelete);

        if (httpResponse.IsSuccessStatusCode)
        {
            var result = await httpResponse.Content.ReadAsStringAsync();
        }

       




    }
}
