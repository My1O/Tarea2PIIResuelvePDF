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
    public class ControllerMenuPrincipal 
    {
        MainWindow principal;
        public ControllerMenuPrincipal(MainWindow principal)
        { 
            this.principal = principal;
        }
        public void MainWindowMenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            switch (menu.Name)
            {
                case "BtnConfigurar":
                    //codigo configurar
                    break;
                case "BtnSalir":
                    Environment.Exit(0);
                    break;
                case "TextMenuItem":
                    ShowFusionTextoLayout();
                    break;
                case "ConversorMenuItem":
                    ShowConversorLayout();
                    break;
            }
        }
        private void ShowConversorLayout()
        {
            ConversorMoneda cm = new ConversorMoneda();
            cm.Show();
        }
        private void ShowFusionTextoLayout()
        {
            FusionTexto fTexto = new FusionTexto();
            fTexto.Show();
        }
    }
}