using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Foto
    {
        public int Id { get; set; }

        public Album Album { get; set; }

        public string FotoNombre { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }
    }
}
