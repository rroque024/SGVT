using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class CotizacionxServicio
    {
        public CotizacionxServicio()
        {
            Pago = new HashSet<Pago>();
        }

        public int PkIdCotizacionxServicio { get; set; }
        public int? FkIdServicio { get; set; }
        public int? FkIdCotizacion { get; set; }
        public DateTime? DFecha { get; set; }
        public DateTime? DHora { get; set; }
        public int? FkIdDistrito { get; set; }
        public double? FMontoFinal { get; set; }

        public Cotizacion FkIdCotizacionNavigation { get; set; }
        public Distrito FkIdDistritoNavigation { get; set; }
        public Servicio FkIdServicioNavigation { get; set; }
        public ICollection<Pago> Pago { get; set; }
    }
}
