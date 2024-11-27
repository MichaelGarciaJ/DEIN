using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public ObservableCollection<Modulo> Modulos { get; set; }

        public Window2()
        {
            InitializeComponent();

            Modulos = new ObservableCollection<Modulo>
            {
                new Modulo { Nombre = "IDM2", Avance = 70, Color = Brushes.Green },
                new Modulo { Nombre = "DEIN", Avance = 85, Color = Brushes.Green },
                new Modulo { Nombre = "DEWB", Avance = 90, Color = Brushes.Green },
                new Modulo { Nombre = "EIDM", Avance = 50, Color = Brushes.Orange },
                new Modulo { Nombre = "PMDM", Avance = 80, Color = Brushes.Green },
                new Modulo { Nombre = "ACDA", Avance = 60, Color = Brushes.Orange },
                new Modulo { Nombre = "PSEP", Avance = 40, Color = Brushes.Red },
                new Modulo { Nombre = "SGEM", Avance = 75, Color = Brushes.Green }
            };

            listModulos.ItemsSource = Modulos;
        }

        private void Mainwindow(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirMainWindow = new MainWindow();
            this.Close();
            AbrirMainWindow.Show();

        }
    }

    public class Modulo
    {
        public string Nombre { get; set; }
        public double Avance { get; set; }
        public Brush Color { get; set; }
    }

}
