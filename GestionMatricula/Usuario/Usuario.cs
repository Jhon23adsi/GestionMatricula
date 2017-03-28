using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMatricula.Conexion;
using GestionMatricula.Facade;

namespace GestionMatricula.Usuario
{
    public class UsuarioAdm
    {

        public UsuarioAdm(string CodUse, string Pw) 
        {
            ValidateUser(CodUse, Pw);
        }
        /// <summary>
        /// Valida la existencia del usuario
        /// </summary>
        /// <param name="CodUse"></param>
        /// <param name="Pw"></param>
        public void ValidateUser(string CodUse, string Pw)
        {            
            UsuarioFacade usuFacade = new UsuarioFacade();            
            try
            {
                if (usuFacade.Usario_Facade(CodUse, Pw)) 
                {
                    MessageBox.Show("Bienvenido", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }                      
        }
    }
}
