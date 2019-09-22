using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class EstadoServicio
    {
        public EstadoServicio()
        {
            Servicio = new HashSet<Servicio>();
        }

        public int PkIdEstadoServicio { get; set; }
        public string NeNombre { get; set; }

        public ICollection<Servicio> Servicio { get; set; }
    }
}
