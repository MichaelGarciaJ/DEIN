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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionEmpleados2024
{

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool EsUsuario { get; set; }
        public int Edad {  get; set; }
    }

    public partial class MainWindow : Window
    {

        private SqlConnection conexionConSql;

        public MainWindow()
        {
            InitializeComponent();
            establecerConexion();
        }

        private void ListEmpleados_Click(object sender, RoutedEventArgs e)
        {
            ListaEmpleados listaEmpleados = new ListaEmpleados();
            listaEmpleados.Show();
        }

        private void BuscarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            BuscarEmpleado buscarEmpleado = new BuscarEmpleado();
            buscarEmpleado.Show();
        }

        private void AgregarEmpleados_Click(object sender, RoutedEventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
        }

        private void establecerConexion()
        {
            string cadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2024.Properties.Settings._A1.13_BdD_Garcia_Michael"].ConnectionString;
            conexionConSql = new SqlConnection(cadenaDeConexion);
        }

        public List<Empleado> obtenerEmpleados()
        {
            establecerConexion();

            string consulta = "SELECT * FROM EMPLEADOS";
            DataTable empleados = new DataTable();

            List<Empleado> listaEmpleados = new List<Empleado>();
            
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionConSql);

            using (adaptador)
            {
                adaptador.Fill(empleados);
            }

            listaEmpleados = empleados.AsEnumerable().Select(row => new Empleado
            {
                Id = row.Field<int>("Id"),
                Nombre = row.Field<string>("Nombre"),
                Apellidos = row.Field<string>("Apellidos"),
                EsUsuario = (row["EsUsuario"] != DBNull.Value) ? row.Field<bool>("EsUsuario") : false,
                Edad = row.Field<int>("Edad"),
            }).ToList();

            return listaEmpleados;
        }



    }
}
