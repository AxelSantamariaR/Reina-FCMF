using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Estudiante: Usuario
    {
        public int EstudianteId { get; set; }

        public string Matricula { get; set; }
    }
}
