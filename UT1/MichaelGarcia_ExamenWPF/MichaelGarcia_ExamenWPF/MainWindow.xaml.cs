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

namespace MichaelGarcia_ExamenWPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          

        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            string id = txtID.Text;
            string producto = txtProducto.Text;
            string precio = txtPrecio.Text;
            double cantidad = sliderControl.Value;

            Product nuevoProducto = new Product(id,producto,precio,cantidad);
            
            dataGridProductos.Items.Add(nuevoProducto);

            txtID.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            sliderControl.Value = 0;

        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            dataGridProductos.Items.Clear();
            txtID.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            sliderControl.Value = 0;
        }

    }

    public class Product
    {
        public string ID { get; set; }
        public string Producto { get; set; }
        public string Precio { get; set; }
        public double Cantidad { get; set; }
        // Otros campos

        // Constructor para crear un objeto Product
        public Product(string id, string nombProducto, string precio, double cantidad)
        {
            ID = id;
            Producto = nombProducto;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
