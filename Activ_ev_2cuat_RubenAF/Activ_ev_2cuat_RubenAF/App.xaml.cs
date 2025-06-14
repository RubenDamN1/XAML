using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Activ_ev_2cuat_RubenAF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Hubo una excepción sin tratar: " + e.Exception.Message, "Error en la aplicación", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = true;
        }
        //Aquí recibo cualquier excepción que pueda producirse
        
    }
}
