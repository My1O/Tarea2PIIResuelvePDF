using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPIIultimaSemana.Models
{
       public class CambioMoneda
    {
        private double Dolar = 35.50;
        private double Euro = 40.02;

        private double valorRegresar;

        public double Convertir(int optionA, int optionB, double MontoMoneda)
        {
            if (optionA == 0 && optionB == 0)
            {
                Console.WriteLine("Monto sera el mismo" + valorRegresar);
            }
            else if (optionA == 0 && optionB == 1)
            { 
                valorRegresar = MontoMoneda / 35.00;
            }else if (optionA == 0 && optionB == 2)
            {
                valorRegresar = MontoMoneda / 39.96;
            }
            
            return valorRegresar;
        }
    }
}
