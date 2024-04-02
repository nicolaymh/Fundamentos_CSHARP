

using _10_Generics.Service;
using _2_Clases_Objetos_Constructores.Models;
using _8_Solicitudes_serviciosWeb_por_HTTP_Get.Models;

Cerveza cerveza = new Cerveza(500, "Ticús")
{ Alcohol = 5, Marca = "Colima" };

SendRequest<Cerveza> service = new SendRequest<Cerveza>();
Cerveza cervezaRespuesta = await service.Send(cerveza);

Console.WriteLine("ok");


// Como estoy trabajando con generics, establezco desde el comienzo con que tipo de objeto voy a trabajar:

Post post = new Post { body = "Soy un body", title = "hola", userId = 50 };

SendRequest<Post> service2 = new SendRequest<Post>();
Post postRespuesta = await service2.Send(post);

Console.WriteLine("ok");
