using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace _1._10.FormularioEmpleado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


    public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

        public MainWindow()
        {
            InitializeComponent();
            ClearForm();
            dataGridEmpleados.ItemsSource = Employees;

        }

        private void txtNombre_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtNombre_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtApellidos_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtApellidos_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtTelefono_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtTelefono_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtDni_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtDni_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void btnCargarFoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show("Foto cargada: " + openFileDialog.FileName);
            }
        }

        private void txtDireccion_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtDireccion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtCiudad_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtCiudad_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtProvincia_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtProvincia_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtCodigoPostal_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtCodigoPostal_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtPais_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtPais_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtEnlaceRedSocial_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtEnlaceRedSocial_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void txtDescricpcion_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void txtDescricpcion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void btnGuardar(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                var employee = new Employee
                {
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    FechaNacimiento = dtPickerFechaNacimiento.SelectedDate,
                    Dni = txtDni.Text,
                    Direccion = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    Provincia = txtProvincia.Text,
                    CodigoPostal = txtCodigoPostal.Text,
                    Pais = txtPais.Text,
                    EnlaceRedSocial = txtEnlaceRedSocial.Text,
                    Rol = cbBoxRol.Text,
                    DescripcionPuesto = txtDescricpcion.Text
                };

                Employees.Add(employee);

                MessageBox.Show("Empleado guardado.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
            }
        }

        private void btnCancelar(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNombre.Text = "Nombre";
            txtApellidos.Text = "Apellidos";
            txtEmail.Text = "Email";
            txtTelefono.Text = "Telefono";
            dtPickerFechaNacimiento.SelectedDate = null;
            txtDni.Text = "Dni";
            txtDireccion.Text = "Dirección";
            txtCiudad.Text = "Ciudad";
            txtProvincia.Text = "Provincia";
            txtCodigoPostal.Text = "Código Postal";
            txtPais.Text = "País";
            txtEnlaceRedSocial.Text = "EnlaceRedSocial";
            txtDescricpcion.Text = "DescripcionPuesto";
            cbBoxRol.SelectedIndex = -1;

            txtNombre.Foreground = Brushes.Gray;
            txtApellidos.Foreground = Brushes.Gray;
            txtEmail.Foreground = Brushes.Gray;
            txtTelefono.Foreground = Brushes.Gray;
            txtDni.Foreground = Brushes.Gray;
            txtDireccion.Foreground = Brushes.Gray;
            txtCiudad.Foreground = Brushes.Gray;
            txtProvincia.Foreground = Brushes.Gray;
            txtCodigoPostal.Foreground = Brushes.Gray;
            txtPais.Foreground = Brushes.Gray;
            txtEnlaceRedSocial.Foreground = Brushes.Gray;
            txtDescricpcion.Foreground = Brushes.Gray;
        }

        private void dataGridEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridEmpleados.SelectedItem is Employee selectedEmployee)
            {
                txtNombre.Text = selectedEmployee.Nombre;
                txtApellidos.Text = selectedEmployee.Apellidos;
                txtEmail.Text = selectedEmployee.Email;
                txtTelefono.Text = selectedEmployee.Telefono;
            }
        }

        private bool ValidateForm()
        {
            return txtNombre.Text != "Nombre" && !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                   txtApellidos.Text !="Apellidos" && !string.IsNullOrWhiteSpace (txtApellidos.Text) &&
                   txtEmail.Text != "Email" && !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                   txtTelefono.Text != "Telefono" && !string.IsNullOrWhiteSpace(txtTelefono.Text);
                  
        }

        private void dataGridEmpleados_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class Employee
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string EnlaceRedSocial { get; set; }
        public string Rol { get; set; }
        public string DescripcionPuesto { get; set; }
    }
}

