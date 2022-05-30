
Console.WriteLine("Bienvenido al sistema de cálculo de promedios por columnas");
Console.WriteLine("");
//Ingreso de cantidad de columnas
Console.WriteLine("Por favor ingrese la cantidad de columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());
Console.WriteLine("");

//Ingreso de cantidad de filas
Console.WriteLine("Por favor ingrese la cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());

//matriz bidimensional
int[,] numeros = new int[cantidadFilas, cantidadColumnas];
//defino lengths
int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//vector de promedios
double[] promedios = new double[cantidadColumnas];
// Recorro la matriz para la carga con elementos de tipo int
for(int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("");
    Console.WriteLine($"Ingrese los valores para la columna Nº {columna + 1}: ");
  
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Ingrese el valor Nº {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("");
Console.WriteLine("--------------/º--º/---------------");
Console.WriteLine("");
// Recorro la matriz y muestro valores
// Calculo el promedio y asigno
double calculoPromedio = 0.00;

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("");
    Console.WriteLine($"Valores de la columna Nº {columna + 1}: ");
    
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor Nº {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);
        calculoPromedio += numeros[fila, columna];
        if (fila == (cantidadFilas - 1))
        {            
            promedios[columna] = calculoPromedio / cantidadFilas;
            calculoPromedio = 0.00;
        }
    }
}
Console.WriteLine("");
//Muestro promedios de columnas almacenados en vector promedios
for (int columna = 0; columna < lengthColumnas; columna++)
{
  Console.Write($"Promedio para la Columna Nº {columna + 1}: ");
  Console.WriteLine(promedios[columna]);
  Console.WriteLine("");
}

