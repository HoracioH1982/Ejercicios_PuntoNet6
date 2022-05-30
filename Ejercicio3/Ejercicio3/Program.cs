
int[] numeros = new int[10];
Console.WriteLine("Hola!, por favor ingrese 10 números:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Número {i+1}?");
    numeros[i] = int.Parse(Console.ReadLine());    
}

var suma = 0.00;
int mayor = numeros[0];
int menor = numeros[0];
var promedio = 0.0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    } 
    if (numeros[i] < menor) 
    {
        menor = numeros[i];
    }
    Console.WriteLine($"Número {i+1}: {numeros[i]}");
 }
promedio = suma / numeros.Length;
Console.WriteLine("");
Console.WriteLine($"La suma de todos los números es: {suma}");
Console.WriteLine($"El número mayor es: {mayor}");
Console.WriteLine($"El número menor es: {menor}");
Console.WriteLine($"El promedio de todos los números es: {promedio}");

