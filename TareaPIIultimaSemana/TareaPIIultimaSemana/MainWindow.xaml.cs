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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TareaPIIultimaSemana.Controllers;

namespace TareaPIIultimaSemana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            SetupController();
        }

        private void SetupController()
        {
            ControllerMenuPrincipal menuPrincipal = new ControllerMenuPrincipal(this);
            RoutedEventHandler routed = new RoutedEventHandler(menuPrincipal.MainWindowMenuItemEventHandler);
            this.TextMenuItem.Click += routed;
            this.ConversorMenuItem.Click += routed;
            
        }
    }
}
