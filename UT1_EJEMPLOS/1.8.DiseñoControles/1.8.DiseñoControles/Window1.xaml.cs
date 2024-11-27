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

namespace _1._8.DiseñoControles
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            cbBoxPersonaje1.Items.Add(new Personaje { Nombre = "Super Mario", ImagenUrl = "imgs/superMario.jpg"});
            cbBoxPersonaje2.Items.Add(new Personaje { Nombre = "Brimstone", ImagenUrl = "imgs/brimstone.jpg" });
            cbBoxPersonaje3.Items.Add(new Personaje { Nombre = "Breaking Bad", ImagenUrl = "imgs/breaking_bad.jpg" });
        }

        private void cmBoxPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (sender is ComboBox comboBox)
            {
                if (comboBox.SelectedItem is Personaje personaje)
                {
                    MessageBox.Show($"Has seleccionado: \n{personaje.Nombre}");
                }
            }

        }

        private void MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirMainWindow = new MainWindow();
            this.Close();
            AbrirMainWindow.Show();
        }
    }

    public class Personaje
    {
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
    }

}
