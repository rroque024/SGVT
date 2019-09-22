using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            CotizacionxServicio = new HashSet<CotizacionxServicio>();
        }

        public int PkIdDistrito { get; set; }
        public string NdDistrito { get; set; }
        public int? IdPesoPrecio { get; set; }

        public ICollection<CotizacionxServicio> CotizacionxServicio { get; set; }
    }
}
