﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Album
    {
        public int Id { get; set; }

        public Candidata Candidata { get; set; }

        public string Nombre { get; set; }
    }
}