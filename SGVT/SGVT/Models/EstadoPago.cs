using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class EstadoPago
    {
        public EstadoPago()
        {
            Pago = new HashSet<Pago>();
        }

        public int PkIdEstadoPago { get; set; }
        public string NeNombre { get; set; }

        public ICollection<Pago> Pago { get; set; }
    }
}
