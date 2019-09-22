using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            CotizacionxServicio = new HashSet<CotizacionxServicio>();
        }

        public int PkIdServicio { get; set; }
        public string NsNombre { get; set; }
        public int? FkIdTrabajador { get; set; }
        public int? FkIdEstadoServicio { get; set; }

        public EstadoServicio FkIdEstadoServicioNavigation { get; set; }
        public Trabajador FkIdTrabajadorNavigation { get; set; }
        public ICollection<CotizacionxServicio> CotizacionxServicio { get; set; }
    }
}
