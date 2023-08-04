using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Candidata
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public DateTime FechaNac { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public Nacionalidad NacionalidadId { get; set; }

        public string FotoNombre { get; set; }

        public string TituloAcademico { get; set; }

        public string Pasatiempos { get; set; }

        public string Habilidades { get; set; }

        public string Intereses { get; set; }

        public string Aspiraciones { get; set; }

        public Idioma IdiomaId { get; set; }
    }
}
