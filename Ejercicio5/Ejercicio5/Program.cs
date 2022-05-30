
//1)      Pedir al usuario la longitud de un vector
Console.Write("Por favor ingrese la longitud del vector: ");
int longitudVector = 0;
longitudVector = int.Parse(Console.ReadLine());
//2)      Crear el vector del tamaño ingresado.
int[] vector = new int[longitudVector];
//3)      Llenar el mismo con datos aleatorios
Random numAleatorios = new Random();
Console.WriteLine("");

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = numAleatorios.Next(100);
}

//4)      Mostrar el vector por pantalla
Console.Write("El contenido inicial del vector es: ");
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(" " + vector[i]);
}
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
//el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector
//es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así:
//50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco
//se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
Console.WriteLine("");
int contador = 0;
int reemplazo = vector[0];
for (int iVueltas = 0; iVueltas < vector.Length ; iVueltas++)
{
    if (contador < longitudVector - 1) 
    {
        vector[contador] = vector[longitudVector - 1];
        vector[longitudVector - 1] = reemplazo;
        contador++;
        reemplazo = vector[contador];          
        longitudVector --;
    }
    else 
    {
        break; 
    }
}
Console.WriteLine(" ");
//6)      Mostrar el vector nuevamente.
Console.Write("El contenido invertido del vector es: ");
for (int i = 0; i < vector.Length; i++)
{
    Console.Write(" " + vector[i]);
}
Console.WriteLine(" ");




