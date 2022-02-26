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
    /// Interaction logic for FusionTexto.xaml
    /// </summary>
    public partial class FusionTexto : Window
    {
       
        public FusionTexto()
        {
            InitializeComponent();
            SetupController();
        }

        private void SetupController()
        {
            ControllerFusionTexto fusionText = new ControllerFusionTexto(this);
            RoutedEventHandler routed = new RoutedEventHandler(fusionText.MainWindowMenuItemEventHandler);
            this.BtnPrimeroArchivo.Click += routed;
            this.BtnSegundoArchivo.Click += routed;
            this.BtnGuardar.Click += routed;
        }
    }
}
