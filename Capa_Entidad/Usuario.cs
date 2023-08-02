using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public PerfilUsuario PerfilUsuario { get; set; }
    }
}
