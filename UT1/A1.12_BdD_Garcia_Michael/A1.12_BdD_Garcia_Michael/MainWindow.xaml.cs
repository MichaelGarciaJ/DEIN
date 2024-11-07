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
using System.Configuration;
using System.Data.SqlClient;

namespace A1._12_BdD_Garcia_Michael
{

    public partial class MainWindow : Window
    {

        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            String miConexion = ConfigurationManager.ConnectionStrings["A1._12_BdD_Garcia_Michael.Properties.Settings._A1.12_BdD_Garcia_Michael"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            muestraCiclos();
        }

        private void muestraCiclos()
        {
            string consulta = "SELECT Denominacion FROM Ciclos";

            List<string> cursos = new List<string>();

            try
            {
                miConexionSql.Open();
                SqlCommand command = new SqlCommand(consulta, miConexionSql);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cursos.Add(reader["Denominacion"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos: " + ex.Message);
            }
            finally
            {
                miConexionSql.Close();
            }


            CursosListBox.ItemsSource = cursos;

        }
    }
}
