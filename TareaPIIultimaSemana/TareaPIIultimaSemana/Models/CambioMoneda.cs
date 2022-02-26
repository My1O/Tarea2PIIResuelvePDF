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

        public double Convertir(string valorA, string valorB, double MontoMoneda)
        {
            String union = valorA + valorB;

            switch (union)
            {
                case "CordobasDolares":
                    valorRegresar = MontoMoneda / Dolar;
                    Console.WriteLine("Cordoba a Dolares: " + valorRegresar);
                    break;
                case "CordobasEuros":
                    valorRegresar = MontoMoneda / Euro;
                    break;
                case "DolaresCordobas":
                    valorRegresar = MontoMoneda * Dolar;
                    break;
                case "DolaresEuros":
                    valorRegresar = MontoMoneda * 0.825297;
                    break;
                case "EurosCordobas":
                    valorRegresar = MontoMoneda * Euro;
                    break;
                case "EurosDolares":
                    valorRegresar = MontoMoneda * 1.21164;
                    break;
            }
            
            return 0.0;
        }
    }
}
