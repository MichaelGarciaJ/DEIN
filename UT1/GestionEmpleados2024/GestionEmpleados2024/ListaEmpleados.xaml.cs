using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class ListaEmpleados : Window
    {

        private MainWindow gestionEmpleados;

        public ListaEmpleados()
        {
            InitializeComponent();
            gestionEmpleados = new MainWindow();
            cargarEmpleadosEnDataGrid();
        }

        private void cargarEmpleadosEnDataGrid()
        {
            List<Empleado> empleados = gestionEmpleados.obtenerEmpleados();
            dataGrid.ItemsSource = empleados;
        }

        private void EliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleadoSeleccionado = (Empleado)dataGrid.SelectedItem;

            if (empleadoSeleccionado != null)
            {
               
                MessageBoxResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar al empleado {empleadoSeleccionado.Nombre} {empleadoSeleccionado.Apellidos}?",
                                                             "Confirmar Eliminación", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (resultado == MessageBoxResult.Yes)
                {
                    if (empleadoSeleccionado.Id > 0)
                    {
                        eliminarEmpleadoDeBaseDatos(empleadoSeleccionado);
                        cargarEmpleadosEnDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error: El ID del empleado no es válido.", "Error de ID", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.", "Selección requerida", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void eliminarEmpleadoDeBaseDatos(Empleado empleado)
        {
            string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2024.Properties.Settings._A1.13_BdD_Garcia_Michael"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "DELETE FROM Empleados WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                if (empleado.Id > 0)
                {
                    comando.Parameters.AddWithValue("@Id", empleado.Id);
                }

                try
                {
                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente.", "Eliminación Exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado a eliminar.", "Error de Eliminación", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
