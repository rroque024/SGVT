using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class TipoCorte
    {
        public TipoCorte()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int PkIdTipoCorte { get; set; }
        public string TpcoNombre { get; set; }
        public int? ItcoPrecio { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
