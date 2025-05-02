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
            using (FileStream xamlFile = new FileStream(@"C:\Users\Ruben Alvarez\Desktop\XAML\Activ_ev_2cuat_RubenAF\Activ_ev_2cuat_RubenAF\PaginaInicial.xaml", FileMode.Open, FileAccess.Read))
            {
                FlowDocument documento = XamlReader.Load(xamlFile) as FlowDocument;
                flowDocReader.Document = documento;
            }
        }
        private void btnCategoria1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnCategoria2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnCategoria3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            using (FileStream xamlFile = new FileStream(@"C:\Users\Ruben Alvarez\Desktop\XAML\Activ_ev_2cuat_RubenAF\Activ_ev_2cuat_RubenAF\FlowDocument2.xaml", FileMode.Open, FileAccess.Read))
            {
                FlowDocument documento = XamlReader.Load(xamlFile) as FlowDocument;
                flowDocReader.Document = documento;
            }
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Salir_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Close_Executed(object sender, ExecutedRoutedEventArgs e) { Application.Current.Shutdown(); }
        private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; }
       
     }
    
}
