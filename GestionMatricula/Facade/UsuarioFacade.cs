using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMatricula.Broker;

namespace GestionMatricula.Facade
{
    public class UsuarioFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CodUsu"></param>
        /// <param name="Pw"></param>
        public bool Usario_Facade(string CodUsu, string Pw) 
        {
            UsuarioBroker usuBroker = new UsuarioBroker();
            return usuBroker.Usuario_broker(CodUsu, Pw);
        }
    }
}
