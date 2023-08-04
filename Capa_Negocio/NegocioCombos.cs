using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioCombos
    {
        DatosCombos datos = new DatosCombos();

        public List<Nacionalidad> getNacionalidades()
        {
            return datos.Nacionalidades("GET_NACIONALIDADES");
        }

        public List<Idioma> getIdiomas()
        {
            return datos.Idiomas("GET_IDIOMAS");
        }
    }
}
