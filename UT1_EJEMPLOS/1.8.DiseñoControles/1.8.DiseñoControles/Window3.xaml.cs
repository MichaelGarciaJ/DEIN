using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        public ObservableCollection<Compañero> Compañeros { get; set; }

        public Window3()
        {
            InitializeComponent();

            Compañeros = new ObservableCollection<Compañero>
            {
                new Compañero { ID = 1, Nombre = "Nestor", Apellido1 = "Aguirre", Apellido2 = "Martinez de Goni" },
                new Compañero { ID = 2, Nombre = "Sergio", Apellido1 = "Ajona", Apellido2 = "Zaldibar" },
                new Compañero { ID = 3, Nombre = "Aritz", Apellido1 = "Ayensa", Apellido2 = "Elizalde" },
                new Compañero { ID = 4, Nombre = "Carla", Apellido1 = "Barbería", Apellido2 = "Flamarique" },
                new Compañero { ID = 5, Nombre = "Diego Fernando", Apellido1 = "Cano", Apellido2 = "Rodriguez" },
                new Compañero { ID = 6, Nombre = "Michael Alexander", Apellido1 = "García", Apellido2 = "Jumbo" },
                new Compañero { ID = 7, Nombre = "Aroa", Apellido1 = "Garde", Apellido2 = "Martinez-Losa" },
                new Compañero { ID = 8, Nombre = "Jon", Apellido1 = "Goñi", Apellido2 = "Jimenez" },
                new Compañero { ID = 9, Nombre = "Aimar", Apellido1 = "Huici", Apellido2 = "Delgado" },
                new Compañero { ID = 10, Nombre = "Paula", Apellido1 = "Iturbide", Apellido2 = "Cristobal" },
                new Compañero { ID = 11, Nombre = "Anthuan", Apellido1 = "Lugris", Apellido2 = "Toymill" },
                new Compañero { ID = 12, Nombre = "Daniel Alejandro", Apellido1 = "Medina", Apellido2 = "Colmenares" },
                new Compañero { ID = 13, Nombre = "Italo Joaquin", Apellido1 = "Ramirez", Apellido2 = "Arellano" },
                new Compañero { ID = 14, Nombre = "Izan", Apellido1 = "Ramos", Apellido2 = "Cervantes" },
                new Compañero { ID = 15, Nombre = "David", Apellido1 = "Reguilón", Apellido2 = "Torres" },
                new Compañero { ID = 16, Nombre = "Yeray", Apellido1 = "Sánchez", Apellido2 = "Rodríguez" },
                new Compañero { ID = 17, Nombre = "Gorka", Apellido1 = "Urabayen", Apellido2 = "Liberal" },
                new Compañero { ID = 18, Nombre = "Unai", Apellido1 = "Urabayen", Apellido2 = "Liberal" }
            };

            dtGridCompaneros.ItemsSource = Compañeros;
        }

        private void Mainwindow(object sender, RoutedEventArgs e)
        {
            MainWindow AbrirMainWindow = new MainWindow();
            this.Close();
            AbrirMainWindow.Show();
        }
    }

    public class Compañero
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
    }
}
