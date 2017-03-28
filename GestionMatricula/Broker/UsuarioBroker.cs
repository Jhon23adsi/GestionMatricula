using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMatricula.Conexion;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace GestionMatricula.Broker
{
    public class UsuarioBroker
    {
        public bool Usuario_broker(string CodUsu, string Pw) 
        {
            bool rtrn = false;
            ConexionDb conn = new ConexionDb();
            var str_conect = conn.init_Conection();
            
            using (str_conect)
            {
                SqlCommand command = new SqlCommand(" SELECT USUARIO.CODUSU, USUARIO.LOGIN FROM USUARIO WHERE USUARIO.CODUSU = @CodUsu ", str_conect);
                command.Parameters.AddWithValue("@CodUsu", CodUsu);
                str_conect.Open();                
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                if (dt.Rows.Count.ToString() == "1") 
                {
                    rtrn = true;                    
                }                
                return rtrn;
            }
            
        }
    }
}
