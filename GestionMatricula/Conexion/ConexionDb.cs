using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionMatricula.Conexion
{
    public class ConexionDb
    {

        SqlConnection connection;
        /// <summary>
        /// Inicia la conexion a la base de datos
        /// </summary>
        public SqlConnection init_Conection()
        {            
            string connectionString = null;
            connectionString = "Data Source=ADMIN\\SQLEXPRESS1;Initial Catalog=REGISTRO;Integrated Security=SSPI;";
            connection = new SqlConnection(connectionString);
            return connection;           
        }      
    }
}
