using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Pago
    {
        public Pago()
        {
            ComprobantePago = new HashSet<ComprobantePago>();
        }

        public int PkIdPago { get; set; }
        public DateTime? DpFecha { get; set; }
        public double? FMonto { get; set; }
        public int? FkIdCotizacionxServicio { get; set; }
        public int? FkIdEstadoPago { get; set; }
        public int? FkIdTipoPago { get; set; }

        public CotizacionxServicio FkIdCotizacionxServicioNavigation { get; set; }
        public EstadoPago FkIdEstadoPagoNavigation { get; set; }
        public TipoPago FkIdTipoPagoNavigation { get; set; }
        public ICollection<ComprobantePago> ComprobantePago { get; set; }
    }
}
