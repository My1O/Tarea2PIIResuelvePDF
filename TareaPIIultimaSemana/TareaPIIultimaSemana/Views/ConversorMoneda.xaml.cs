using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TareaPIIultimaSemana.Controllers;

namespace TareaPIIultimaSemana.Views
{
    /// <summary>
    /// Interaction logic for ConversorMoneda.xaml
    /// </summary>
    /// 
    public partial class ConversorMoneda : Window
    {
        public ConversorMoneda()
        {
            InitializeComponent();
            SetupController();
        }

        private void SetupController()
        {
            ControllerConversorMoneda conversorMoneda = new ControllerConversorMoneda(this);
            RoutedEventHandler routed = new RoutedEventHandler(conversorMoneda.MainWindowMenuItemEventHandler);
            this.BtnCalcular.Click += routed;
            
        }
    }
}
