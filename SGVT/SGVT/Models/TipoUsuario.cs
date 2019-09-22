using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int PkIdTipoUsuario { get; set; }
        public string NtNombre { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
