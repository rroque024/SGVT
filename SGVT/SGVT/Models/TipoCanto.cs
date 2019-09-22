using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class TipoCanto
    {
        public TipoCanto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int PkIdTipoCanto { get; set; }
        public string NtcaNombre { get; set; }
        public string NtcaDescripcion { get; set; }
        public int? ItcaPrecio { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
