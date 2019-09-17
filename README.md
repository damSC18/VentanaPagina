# VentanaPagina
Crear Aplicaciones WPF con Window o Page

Ventana(window) o página(page)
 Podemos trabajar con interfaces basados en ventanas Window o en Page.
	La ventanas  Window diseñan interfaces de tipo windows y las  Page  simular un navegador de internet permitiendo volver a la venta a anterior o siguiente.

	Por defecto se crean proyecto con interfaces de tipo Window. 
Fichero App.xaml
<Application x:Class="VentanaPagina.App" 
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:VentanaPagina"
             StartupUri="MainWindow.xaml"> //Indica la window  o page que se visualiza 
    <Application.Resources>
         
    </Application.Resources>
</Application>
Fichero App.xaml.css
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VentanaPagina
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}

Fichero MainWindow.xaml

//En este fichero se define el tipo de navegación a utilizar window o page
// La opción que utiliza .net  por defecto es Window. En este caso añade un contenedor <Grid> donde se añadimos  los controles del interfaz.
<Window x:Class="VentanaPagina.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"       
        mc:Ignorable="d"
        Title="MainWindow" Height="542" Width="1074"
        xmlns:src="clr-namespace:CrudArray">
	 <Grid Margin="0,0,2,54">
        <Label Content="Apuntes 2019-2020" HorizontalAlignment="Left" Margin="14,0,0,0" 			VerticalAlignment="Top" Width="432" RenderTransformOrigin="0.5,0.5" 			Height="70" FontSize="48" FontFamily="Viner Hand ITC" Background="{x:Null}" 
		Foreground="#FF726666">
         </Label>
	</Grid> 
</Window

//Si queremos trabajar con Page, no lo podemos hacer directamente en MainWindow.xaml, aquí lo que hacemos es modificar de forma manual Windows por  NavigationWindow.
Y el propiedad Source="Pagina.xaml" indicamos la Page a visualizar. En este fichero "Pagina.xaml"  si podemos utilizar en contenedor <Grid> para añadir los controles del interfaz.  
<NavigationWindow x:Class="VentanaPagina.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:VentanaPagina"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800"  Source="Pagina.xaml">         
</NavigationWindow>

Fichero  Pagina.xaml
<Page x:Class="VentanaPagina.Pagina"
    …....
      Title="Pagina">

    <Grid>
	<Label Content="Apuntes 2019-2020" HorizontalAlignment="Left" Margin="14,0,0,0" 			VerticalAlignment="Top" Width="432" RenderTransformOrigin="0.5,0.5" 			Height="70" FontSize="48" FontFamily="Viner Hand ITC" Background="{x:Null}" 
		Foreground="#FF726666">
         </Label>
    </Grid> 
 </Page> 


Fichero MainWindow.xaml.cs

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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ventana v = new Ventana();
            v.Show();
        }
    }
}

Fichero Pagina.xamls
<Page x:Class="VentanaPagina.Pagina"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns:local="clr-namespace:VentanaPagina"
      mc:Ignorable="d" 
      d:DesignHeight="450" d:DesignWidth="800"
      Title="Pagina">

    <Grid>
        <Button Content="Ventana" HorizontalAlignment="Left" Margin="160,100,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click"/>
        <Button Content="Pagina Siguiente&#xD;&#xA;" HorizontalAlignment="Left" Margin="410,100,0,0" VerticalAlignment="Top" Width="295" Click="Button_Click_1"/>

    </Grid>
</Page>

Fichero Pagina.xaml.cs
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
		//Crea un objeto window a partir de Ventana y los muestra con  v.Show();
            Ventana v = new Ventana();
            v.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
		//Crea un objeto Page a partir de PaginaSiguiente y los muestra
		por medio de   this.NavigationService.Navigate(mipagina);

            PaginaSiguiente mipagina = new PaginaSiguiente();
            this.NavigationService.Navigate(mipagina);
        }
    }
}

Fichero Ventana.xaml
<Window x:Class="VentanaPagina.Ventana"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:VentanaPagina"
        mc:Ignorable="d"
        Title="Ventana" Height="450" Width="800">
    <Grid>
        <Button Content="Cerrar" HorizontalAlignment="Left" Margin="265,125,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click"/>
    </Grid>
</Window>

Fichero Ventana.xaml.cs
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

namespace VentanaPagina
{
    /// <summary>
    /// Lógica de interacción para Ventana.xaml
    /// </summary>
    public partial class Ventana : Window
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
Fichero PaginaSiguiente.xaml
<Page x:Class="VentanaPagina.PaginaSiguiente"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns:local="clr-namespace:VentanaPagina"
      mc:Ignorable="d" 
      d:DesignHeight="450" d:DesignWidth="800"
      Title="PaginaSiguiente">

    <Grid>
        <Label Content="Página Siguiente" HorizontalAlignment="Left" Margin="155,95,0,0" VerticalAlignment="Top" Width="540"/>
    </Grid>
</Page>

Fichero PaginaSiguiente.xaml.cs
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
    /// Lógica de interacción para PaginaSiguiente.xaml
    /// </summary>
    public partial class PaginaSiguiente : Page
    {
        public PaginaSiguiente()
        {
            InitializeComponent();
        }
    }
}
