using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class TipoCristal
    {
        public TipoCristal()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int PkIdTipoCristal { get; set; }
        public string NtcNombre { get; set; }
        public string NtcDescripcion { get; set; }
        public int? ItcPrecio { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
