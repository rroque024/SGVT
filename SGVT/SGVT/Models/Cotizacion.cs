using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Cotizacion
    {
        public Cotizacion()
        {
            CotizacionxServicio = new HashSet<CotizacionxServicio>();
        }

        public int PkIdCotizacion { get; set; }
        public int? FkDni { get; set; }
        public int? FkIdPedido { get; set; }
        public double? FcMontoInicial { get; set; }

        public Usuario FkDniNavigation { get; set; }
        public Pedido FkIdPedidoNavigation { get; set; }
        public ICollection<CotizacionxServicio> CotizacionxServicio { get; set; }
    }
}
