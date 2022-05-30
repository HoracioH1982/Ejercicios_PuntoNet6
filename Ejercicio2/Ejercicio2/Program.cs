//// Genera un numero entero aleatorio de 1 a 20
int opcionUsuario = 0;
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

//Pedir al usuario que ingrese un número y que intente adivinar
Console.WriteLine("Ingrese un número del 1 al 20 e intente adivinar el número que eligió la computadora... veremos si es el elegido!!");
opcionUsuario = int.Parse(Console.ReadLine());
int cantIntentos = 1;

do
{
    Console.Clear();
    cantIntentos ++;
    // Si es mayor avisarle que es muy grande y que intente de nuevo
    if (opcionUsuario > numeroSecreto)
    {
    Console.WriteLine("El número ingresado es muy grande!, intente ingresando uno distinto!");
    opcionUsuario = int.Parse(Console.ReadLine());
    } else
    // Si es menor, avisarle que es muy chico, y que intente de nuevo
    if (opcionUsuario < numeroSecreto)
       {
        Console.WriteLine("El número ingresado es muy chico!, intente ingresando uno distinto!");
        opcionUsuario = int.Parse(Console.ReadLine());
       }

} while (opcionUsuario != numeroSecreto);
//Si coincide mandar mensaje
Console.Clear();
Console.WriteLine($"¡Felicitaciones!, has adivinado el número secreto que era {numeroSecreto}");
Console.WriteLine($"lo has logrado en {cantIntentos} intentos!!.");
//Y finalizar el programa.
