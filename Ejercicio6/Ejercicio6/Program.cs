//1)    Cartón de 3 filas por 9 columnas
int[,] carton = new int[9, 3];
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19,
//la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90

//Cantidad de filas
int lengthFilas = carton.GetUpperBound(1) + 1;

//Cantidad de columnas
int lengthColumnas = carton.GetUpperBound(0) +1; 
//Definimos Random
Random aleatorio = new Random();

int cantXColumna = 0;
int columna = 0;
int auxNum, linea = 0;

Console.WriteLine("Bienvenidos al Bingo!");
Console.WriteLine("");
Console.WriteLine("Presione una tecla para generar su cartón");
Console.ReadKey();
Console.WriteLine("");

for (int i = 0; i < lengthColumnas; i++)
{
    //cantidad de números por columna
    if (columna == 3 || columna == 5 || columna == 7) 
    {
        cantXColumna = 1;
    }else
    {
        cantXColumna = 2;
    }
    auxNum = 0;
    for (int j = 0; j < cantXColumna; j++)
    {
        switch (columna)
        {
            case 0:
                carton[columna, linea] = aleatorio.Next(1, 9);
                break;
            case 1:
                carton[columna, linea] = aleatorio.Next(10, 19);
                break;
            case 2:
                carton[columna, linea] = aleatorio.Next(20, 29);
                break;
            case 3:
                carton[columna, linea] = aleatorio.Next(30, 39);
                break;
            case 4:
                carton[columna, linea] = aleatorio.Next(40, 49);
                break;
            case 5:
                carton[columna, linea] = aleatorio.Next(50, 59);
                break;
            case 6:
                carton[columna, linea] = aleatorio.Next(60, 69);
                break;
            case 7:
                carton[columna, linea] = aleatorio.Next(70, 79);
                break;
            case 8:
                carton[columna, linea] = aleatorio.Next(80, 90);
                break;
        }        
        if (carton[columna, linea] == auxNum)
        {
             j--;            
        }else
        {
            auxNum = carton[columna, linea];
        }
        if (linea == 0)
        {
            linea = 2;
        }
        else if (linea == 2)
        {
            linea = 1;
        }
        else if (linea == 1)
        {
            linea = 0;
        }
        if (cantXColumna == j+1)
        {
            columna++;            
        }
      }
    }

//7)    Mostrar el carton por pantalla
Console.Write("         ");
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("══════════════════════════════════════════════");
for (int fila = 0; fila < lengthFilas; fila++)
{
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.ResetColor();
    Console.Write("         ");
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("║");
    for (int columna1 = 0; columna1 < lengthColumnas; columna1++)
    {
        if (carton[columna1,fila] == 0) 
        { 
           Console.Write("████║");
        } else if (columna1 == 0)
               {
                   Console.Write($" 0{carton[columna1, fila]} ║");
               } else
                    {
                        Console.Write($" {carton[columna1, fila]} ║");
                    }
        if (columna1 == 8)
        {
            Console.WriteLine("");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ResetColor();
            Console.Write("         ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("══════════════════════════════════════════════");
        }
    }    
}
Console.ResetColor();
