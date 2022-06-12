using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.Modelo
{
    internal class Billetera
    {
        //1) Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        // Constructor
        public Billetera()
        {
            BilletesDe10 = 10;
            BilletesDe20 = 10;
            BilletesDe50 = 10;
            BilletesDe100 = 10;
            BilletesDe200 = 10;
            BilletesDe500 = 10;
            BilletesDe1000 = 10;
        }
        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100,
            int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        //2) Agregar un método que se llame Total del tipo decimal, y que devuelva
        //el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga
        //de cada tipo.
        public decimal Total()
        {
            decimal total = ((BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) +
            (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000));
            return total; 
        }
        //3) Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera
        //y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  

        public void Combinar(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100,
            int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10 = (BilletesDe10 += billetesDe10);
            BilletesDe20 = (BilletesDe20 += billetesDe20);
            BilletesDe50 = (BilletesDe50 += billetesDe50);
            BilletesDe100 = (BilletesDe100 += billetesDe100);
            BilletesDe200 = (BilletesDe200 += billetesDe200);
            BilletesDe500 = (BilletesDe500 += billetesDe500);
            BilletesDe1000 = (BilletesDe1000 += billetesDe1000);           
        }
        //4) Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan
        //quedar en cero. (Sin billetes)
        public void VaciarBilleteras()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

    }
}
