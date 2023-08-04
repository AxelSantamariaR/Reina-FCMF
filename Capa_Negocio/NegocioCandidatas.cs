using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NegocioCandidatas
    {
        DatosCandidata datos = new DatosCandidata();

        public Respuesta AddCandidata(Candidata candidata)
        {
            return datos.AgregarCandidata("AGREGAR_CANDIDATA", candidata);
        }

        public int CrearAlbum(Album album)
        {
            return datos.CrearAlbum("CREAR_ALBUM", album);
        }

        public int AgregarFotos(List<Foto> foto)
        {
            int bandera = 0;
            foreach (var item in foto)
            {
                bandera = datos.AgregarFoto("AGREGAR_FOTO", item);
            }
            return bandera;
        }
    }
}
