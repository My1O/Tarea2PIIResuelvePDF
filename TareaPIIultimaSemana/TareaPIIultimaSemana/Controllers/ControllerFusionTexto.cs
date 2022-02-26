using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TareaPIIultimaSemana.Views;

namespace TareaPIIultimaSemana.Controllers
{
    public class ControllerFusionTexto
    {
        FusionTexto fusionTexto;

        public ControllerFusionTexto(FusionTexto fusionTexto)
        {
            this.fusionTexto = fusionTexto;
        }
        public void MainWindowMenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            Button menu = (Button)sender;
            switch (menu.Name)
            {
                case "BtnPrimeroArchivo":
                    AbrirPrimerArchivo();
                    break;
                case "BtnSegundoArchivo":
                    AbrirSegundoArchivo();
                    break;
                case "BtnGuardar":
                    Save();
                    break;
            }
        }
        private void AbrirPrimerArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                var ruta = openFileDialog.FileName;
                fusionTexto.txtPrimero.Text = ruta;

                using(var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using(var sr = new StreamReader(fs))
                    {
                        string lectura = sr.ReadToEnd();
                        string contenido = fusionTexto.txtMostrar.Text;

                        if(fusionTexto.txtSegundo.Text == "")
                        {
                            fusionTexto.txtMostrar.Text = lectura;
                        }
                        else
                        {
                            fusionTexto.txtMostrar.Text += " ";
                            fusionTexto.txtMostrar.Text += lectura;
                        }
                    }
                }             
            }
            
        }
        private void Save()
        {
            string txtPrimero = fusionTexto.txtPrimero.Text;
            string txtSegundo = fusionTexto.txtSegundo.Text;


            if(txtPrimero == "" || txtSegundo == "")
            {
                MessageBox.Show("Tienes que cargar los 2 archivos");
            }
            else
            {
                string contenidoTotal = fusionTexto.txtMostrar.Text;
                SaveFileDialog sv = new SaveFileDialog();
                if(sv.ShowDialog()==true)
                {
                    File.WriteAllText(sv.FileName, contenidoTotal);
                    MessageBox.Show("Exito al guardar");
                }
            }
        }
        private void AbrirSegundoArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                var ruta = openFileDialog.FileName;

                fusionTexto.txtSegundo.Text = ruta;
                using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        string lectura = sr.ReadToEnd();
                        string contenido = fusionTexto.txtMostrar.Text;

                        if (fusionTexto.txtPrimero.Text == "")
                        {
                            fusionTexto.txtMostrar.Text = lectura;
                        }
                        else
                        {
                            fusionTexto.txtMostrar.Text += " ";
                            fusionTexto.txtMostrar.Text += lectura;
                        }
                    }
                }
            }

        }
    }
}
