using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioUsuarios
    {
        DatosUsuario datosUsuario = new DatosUsuario();

        public DataTable Tablas(string transaccion)
        {
            return datosUsuario.LlenasTablas(transaccion);
        }

        public bool ValidarAtributo(string transaccion, string parametro)
        {
            return datosUsuario.Validar(transaccion, parametro);
        }

        public Respuesta AgregarAdmiOrGestor(string transaccion, Usuario usuario)
        {
            return datosUsuario.AgregarUsuario(transaccion, usuario);
        }

        public Respuesta AgregarEstudiante(string transaccion, Estudiante estudiante)
        {
            return datosUsuario.AgregarEstudiante(transaccion, estudiante);
        }

    }
}
