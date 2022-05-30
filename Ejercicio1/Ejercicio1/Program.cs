var respuesta = "S";
var nombre = "";

while (respuesta.ToUpper() == "S") { 
    Console.Clear();
    Console.WriteLine("Ingrese su nombre:");
    nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");
    Console.WriteLine("Desea Continuar: (S/N)");
    respuesta = Console.ReadLine();
 }
if (respuesta.ToUpper() == "N")
{    
    Console.WriteLine("Programa finalizado correctamente");
    Console.ReadKey();
} else
{
    Console.WriteLine("Opcion no válida");
    Console.ReadKey();
}






