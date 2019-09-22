using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Pago = new HashSet<Pago>();
        }

        public int PkIdTipoPago { get; set; }
        public string NtNombre { get; set; }

        public ICollection<Pago> Pago { get; set; }
    }
}
