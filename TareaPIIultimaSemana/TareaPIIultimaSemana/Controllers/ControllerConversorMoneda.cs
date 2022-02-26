using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TareaPIIultimaSemana.Views;

namespace TareaPIIultimaSemana.Controllers
{
    internal class ControllerConversorMoneda
    {
        ConversorMoneda conversor;
        public ControllerConversorMoneda(ConversorMoneda conversor)
        {
            this.conversor = conversor;
        }
        public void MainWindowMenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            Button menu = (Button)sender;

            switch (menu.Name)
            {
                    case "BtnCalcular":
                    CalculaMonto();
                    break;
            }
        }
        private void CalculaMonto()
        {
            string fecha = DateTime.Now.Date.ToString("dd-MM-yyyy");
            conversor.fecha.Content = fecha;

            string txtIngresoValor = conversor.MonedaConvertir.ToString();
            string txtMontoResultado = conversor.MontoConvertido.ToString();
            //string comboBoxSeleccionUno = conversor
            

        }
    }
}