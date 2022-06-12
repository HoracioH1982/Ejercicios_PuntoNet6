using Ejercicio7.Modelo;

Console.WriteLine("");
Console.WriteLine("Bienvenidos al sistema de combinación de billeteras");
Console.WriteLine("");

var Billetera1 = new Billetera();

Console.WriteLine($"La suma total de Billetes de la Billetera 1 es: $ {Billetera1.Total().ToString("N2")}");
Console.WriteLine("");

var Billetera2 = new Billetera(20,20,10,15,12,5,13);

Console.WriteLine($"La suma total de Billetes de la Billetera 2 es: $ {Billetera2.Total().ToString("N2")}");
Console.WriteLine("");

var BilleteraTotal = new Billetera();
BilleteraTotal.Combinar(Billetera2.BilletesDe10, Billetera2.BilletesDe20, Billetera2.BilletesDe50,
                        Billetera2.BilletesDe100, Billetera2.BilletesDe200, Billetera2.BilletesDe500,
                        Billetera2.BilletesDe1000);

Console.WriteLine("Combinamos billeteras?, presione una tecla para continuar");
Console.ReadKey();

Console.WriteLine("");
Console.WriteLine($"La suma total de ambas billeteras combinadas es: $ { BilleteraTotal.Total().ToString("N2")}");
Console.WriteLine("");

Billetera1.VaciarBilleteras();
Billetera2.VaciarBilleteras();

Console.WriteLine($"La suma total luego de Combinar de la Billetera 1 es: $ {Billetera1.Total().ToString("N2")}");
Console.WriteLine("");
Console.WriteLine($"La suma total luego de Combinar de la Billetera 2 es: $ {Billetera2.Total().ToString("N2")}");
Console.WriteLine("");






