using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;
using XamlReader = System.Windows.Markup.XamlReader;

namespace Activ_ev_2cuat_RubenAF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //XamlReader lector;
        public MainWindow()
        {
            InitializeComponent();
            using (FileStream xamlFile = new FileStream(@"../../Paginas/PaginaInicial.xaml", FileMode.Open, FileAccess.Read))
            {
                FlowDocument documento = XamlReader.Load(xamlFile) as FlowDocument;
                flowDocReader.Document = documento;
            }
        }
        
        private void btnNoticias_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnPescadores_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnPrediccion_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
            CargarArticulo();
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Salir_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Close_Executed(object sender, ExecutedRoutedEventArgs e) { Application.Current.Shutdown(); }
        private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }

        //metodo para cargar un articulo
        private void CargarArticulo()
        {
            FlowDocument contenido = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos FlowDocument (*.xaml)|*.xaml";

            if (openFile.ShowDialog() == true)
            {
                FileStream archivoXaml = openFile.OpenFile() as FileStream;
                if (archivoXaml == null) return;
                else
                {
                    try
                    {
                        contenido = XamlReader.Load(archivoXaml) as FlowDocument;
                        if (contenido == null)
                            throw (new System.Windows.Markup.XamlParseException("The specified file could not be loaded as a FlowDocument."));
                    }
                    catch (Exception e) 
                    {
                        String error = "Hubo un problema cargando el archivo\n\n";                        
                        error += openFile.FileName;
                        error += "\nDetalles:\n\n";
                        error += e.Message;
                        System.Windows.MessageBox.Show(error);
                        return;
                    }
                    flowDocReader.Document = contenido;
                }
            }
            
            
        }
       
     }
    
}
