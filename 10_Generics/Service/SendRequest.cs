

using _10_Generics.Models;
using System.Text.Json;

namespace _10_Generics.Service
{
    // La T indica que va a recibir una clase que la va a definir el objeto con el que va a trabajar.
    public class SendRequest<T> where T : IRequestable
    {
        private HttpClient _client = new HttpClient();

        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/";

            string data = JsonSerializer.Serialize<T>(model);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await _client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                string result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<T>(result);

                return postResult;
            }

            return default(T);
        }
    }
}
