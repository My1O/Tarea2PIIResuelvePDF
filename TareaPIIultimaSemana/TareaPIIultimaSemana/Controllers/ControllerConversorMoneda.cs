using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TareaPIIultimaSemana.Models;
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
            
            int comboBoxPrimero = Convert.ToInt32(conversor.CmbPrimero.SelectedIndex.ToString());
            int comboBoxSegundo = Convert.ToInt32(conversor.CmbSegundo.SelectedIndex.ToString());
            //MessageBox.Show(Convert.ToString(comboBoxPrimero) + ""+Convert.ToString(comboBoxSegundo));

            double MontoACalcular = Convert.ToDouble(conversor.txtMontoACalcular.Text);
            
            
            CambioMoneda cm = new CambioMoneda();
            double Resultado = cm.Convertir(comboBoxPrimero, comboBoxSegundo, MontoACalcular);
            MessageBox.Show(Resultado.ToString());
            conversor.txtResultado.Text = Resultado.ToString();

        }
    }
}