using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Cotizacion = new HashSet<Cotizacion>();
        }

        public int PkIdPedido { get; set; }
        public double? FAltura { get; set; }
        public double? FAncho { get; set; }
        public double? FDiametro { get; set; }
        public int? ICantidad { get; set; }
        public int? FkIdTipoCanto { get; set; }
        public int? FkIdTipoCristal { get; set; }
        public int? FkIdProducto { get; set; }
        public int? FkIdTipoCorte { get; set; }

        public Producto FkIdProductoNavigation { get; set; }
        public TipoCanto FkIdTipoCantoNavigation { get; set; }
        public TipoCorte FkIdTipoCorteNavigation { get; set; }
        public TipoCristal FkIdTipoCristalNavigation { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }
    }
}
