using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Trabajador
    {
        public Trabajador()
        {
            Servicio = new HashSet<Servicio>();
        }

        public int PkIdTrabajador { get; set; }
        public string NtNombre { get; set; }
        public string NtApaterno { get; set; }
        public string NtAmaterno { get; set; }
        public int? ItCelular { get; set; }

        public ICollection<Servicio> Servicio { get; set; }
    }
}
