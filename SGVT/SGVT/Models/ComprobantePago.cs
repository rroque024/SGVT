using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class ComprobantePago
    {
        public int PkIdComprobantePago { get; set; }
        public string NCabecera { get; set; }
        public int? FkIdPago { get; set; }

        public Pago FkIdPagoNavigation { get; set; }
    }
}
