using _10_Generics.Models;


namespace _8_Solicitudes_serviciosWeb_por_HTTP_Get.Models
{
    public class Post : IRequestable
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
