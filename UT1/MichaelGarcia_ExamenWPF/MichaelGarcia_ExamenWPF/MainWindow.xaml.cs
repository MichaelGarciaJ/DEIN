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

        private int currentId = 1;

        public MainWindow()
        {
            InitializeComponent();
            AgregarProductoInicial("Producto 1", "10.99", 5);
            AgregarProductoInicial("Producto 2", "20.49", 10);


        }

        private void AgregarProductoInicial(string nombreProducto, string precio, double cantidad)
        {
            string id = currentId.ToString();

            Product nuevoProducto = new Product(id, nombreProducto, precio, cantidad);
            dataGridProductos.Items.Add(nuevoProducto);

            currentId++;
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            
            if (dataGridProductos.SelectedItem is Product productoSeleccionado)
            {
               
                productoSeleccionado.Producto = txtProducto.Text;
                productoSeleccionado.Precio = txtPrecio.Text;
                productoSeleccionado.Cantidad = sliderControl.Value;

                dataGridProductos.Items.Refresh();
            }
            else
            {
                string id = currentId.ToString();
                string producto = txtProducto.Text;
                string precio = txtPrecio.Text;

                if (producto.Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre del producto no puede contener números.");
                    return;
                }

                if (!double.TryParse(precio, out double precioNum))
                {
                    MessageBox.Show("El precio debe ser un número válido.");
                    return;
                }

                double cantidad = sliderControl.Value;

                Product nuevoProducto = new Product(id, producto, precio, cantidad);
                    
                dataGridProductos.Items.Add(nuevoProducto);
                          
                currentId++;
            }
                  
            txtProducto.Text = "";
            txtPrecio.Text = "";
            sliderControl.Value = 0;
            txtID.Text = "";

        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            dataGridProductos.Items.Clear();
            txtID.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            sliderControl.Value = 0;
        }

        private void dataGridProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridProductos.SelectedItem is Product productoSeleccionado)
            {
                txtID.Text = productoSeleccionado.ID;
                txtProducto.Text = productoSeleccionado.Producto;
                txtPrecio.Text = productoSeleccionado.Precio;
                sliderControl.Value = productoSeleccionado.Cantidad;
            }
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
