using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace GestionEmpleados2024
{

    public partial class BuscarEmpleado : Window
    {

        private SqlConnection conexionConSql;

        public BuscarEmpleado()
        {
            InitializeComponent();
            establecerConexion();
            placeHolder();
        }

        private void ActualizarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleadoSeleccionado = (Empleado)dataGridResultados.SelectedItem;

            if (empleadoSeleccionado != null)
            {
                
                modificarEmpleado(empleadoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para actualizar.", "Selección requerida", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void establecerConexion()
        {
            string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2024.Properties.Settings._A1.13_BdD_Garcia_Michael"].ConnectionString;
            conexionConSql = new SqlConnection(cadenaDeConexion);
        }

        private void modificarEmpleado(Empleado empleado)
        {
            establecerConexion();

            string consulta = "UPDATE Empleados SET Nombre = @Nombre, Apellidos = @Apellidos, EsUsuario = @EsUsuario, Edad = @Edad WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(consulta, conexionConSql);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
            cmd.Parameters.AddWithValue("@EsUsuario", empleado.EsUsuario);
            cmd.Parameters.AddWithValue("@Edad", empleado.Edad);
            cmd.Parameters.AddWithValue("@Id", empleado.Id);

            try
            {
                conexionConSql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado correctamente.", "Actualización Exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                conexionConSql.Close();
            }
        }

        private void BuscarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtBuscarNombre.Text;
            string apellidos = txtBuscarApellidos.Text;
            int.TryParse(txtBuscarEdad.Text, out int edad);

            List<Empleado> empleadosEncontrados = buscarEmpleados(nombre, apellidos, edad);

            if (empleadosEncontrados.Count > 0)
            {
                dataGridResultados.ItemsSource = empleadosEncontrados;
            }
            else
            {
                MessageBox.Show("No se encontraron empleados con los criterios de búsqueda especificados.", "Búsqueda sin resultados", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private List<Empleado> buscarEmpleados(string nombre, string apellidos, int edad)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            establecerConexion();

            string consulta = "SELECT * FROM Empleados WHERE " +
                              "(Nombre LIKE @Nombre OR @Nombre IS NULL) AND " +
                              "(Apellidos LIKE @Apellidos OR @Apellidos IS NULL) AND " +
                              "(Edad = @Edad OR @Edad = 0)";

            SqlCommand cmd = new SqlCommand(consulta, conexionConSql);
            cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : "%" + nombre + "%");
            cmd.Parameters.AddWithValue("@Apellidos", string.IsNullOrEmpty(apellidos) ? (object)DBNull.Value : "%" + apellidos + "%");
            cmd.Parameters.AddWithValue("@Edad", edad);

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable empleados = new DataTable();

            try
            {
                adaptador.Fill(empleados);

                listaEmpleados = empleados.AsEnumerable().Select(row => new Empleado
                {
                    Id = row.Field<int>("Id"),
                    Nombre = row.Field<string>("Nombre"),
                    Apellidos = row.Field<string>("Apellidos"),
                    EsUsuario = row.Field<bool>("EsUsuario"),
                    Edad = row.Field<int>("Edad")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return listaEmpleados;
        }

        private void placeHolder()
        {
            txtBuscarNombre.Text = "Nombre";
            txtBuscarApellidos.Text = "Apellidos";
            txtBuscarEdad.Text = "Edad";

            txtBuscarNombre.Foreground = Brushes.Gray;
            txtBuscarApellidos.Foreground = Brushes.Gray;
            txtBuscarEdad.Foreground = Brushes.Gray;
        }

    }
}
