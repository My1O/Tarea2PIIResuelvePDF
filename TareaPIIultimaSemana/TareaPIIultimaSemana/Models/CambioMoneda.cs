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
            //cordobas
            if (optionA == 0 && optionB == 0)
            {
                valorRegresar = MontoMoneda;
            }
            else if (optionA == 0 && optionB == 1)
            { 
                valorRegresar = MontoMoneda / 35.00;
            }else if (optionA == 0 && optionB == 2)
            {
                valorRegresar = MontoMoneda / 39.96;
            }
            //doares
            else if (optionA == 1 && optionB == 0)
            {
                valorRegresar = MontoMoneda * 35.50;
            }
            else if (optionA == 1 && optionB == 1)
            {
                valorRegresar = MontoMoneda;
            }
            else if (optionA == 1 && optionB == 2)
            {
                valorRegresar = MontoMoneda * 0.8872;
            }//Euros
            else if (optionA == 2 && optionB == 0)
            {
                valorRegresar = MontoMoneda / 39.9670;
            }
            else if (optionA == 2 && optionB == 1)
            {
                valorRegresar = MontoMoneda / 1.1271;
            }
            else if (optionA == 2 && optionB == 2)
            {
                valorRegresar = MontoMoneda;
            }

            return valorRegresar;
        }
    }
}
