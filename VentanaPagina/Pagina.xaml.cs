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

namespace VentanaPagina
{
    /// <summary>
    /// Lógica de interacción para Pagina.xaml
    /// </summary>
    public partial class Pagina : Page
    {
        public Pagina()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ventana v = new Ventana();
            v.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PaginaSiguiente mipagina = new PaginaSiguiente();
            this.NavigationService.Navigate(mipagina);
        }
    }
}
