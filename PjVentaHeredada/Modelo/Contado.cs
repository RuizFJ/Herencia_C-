using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public  class Contado : Venta
    {

        public static int n;
        public Contado()
        {
            n++;
        }

        public int GetN()
        {
            return n;
        }
        //Metodo clase contado 

        public double CalculaDescuento(double subTotal)
        {
            if (subTotal < 1000)
            {
                return 2.0 / 100 * subTotal;
            } else if (subTotal >= 1000 && subTotal <= 3000)
            {
                return 5.0 / 100 * subTotal;
            } else
            {
                 return 12.0 / 100 * subTotal;
            }
        }
        public double CalcularNeto(double subTotal, double descuento)
        {
            return subTotal - descuento;
        }
        

        

    }
}
