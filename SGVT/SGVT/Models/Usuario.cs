using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cotizacion = new HashSet<Cotizacion>();
        }

        public int PkDni { get; set; }
        public string NuNombre { get; set; }
        public string NuApaterno { get; set; }
        public string NuAmaterno { get; set; }
        public string NuCorreo { get; set; }
        public int IuCelular { get; set; }
        public string NuDireccion { get; set; }
        public string NuContraseña { get; set; }
        public int FkIdTipoUsuario { get; set; }

        public TipoUsuario FkIdTipoUsuarioNavigation { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }
    }
}
