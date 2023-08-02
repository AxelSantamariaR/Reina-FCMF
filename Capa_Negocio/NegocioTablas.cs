using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioTablas
    {
        DatosTables DatosTab = new DatosTables();

        public DataTable Tablas(string transaccion)
        {
            return DatosTab.LlenasTablas(transaccion);
        }
    }
}
