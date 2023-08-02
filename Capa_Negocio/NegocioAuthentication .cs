using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioAuthentication
    {
        DatosAuthentication DatosAut = new DatosAuthentication();

        public Usuario Login(string username, string password)
        {
            return DatosAut.Authentication(username, password);
        }
    }
}
