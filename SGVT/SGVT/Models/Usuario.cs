using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGVT.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cotizacion = new HashSet<Cotizacion>();
        }
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        [Range(00000000, 99999999, ErrorMessage = "Campo valido de 8 digitos")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public int PkDni { get; set; }
        
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "* Solo se permiten letras.")]
        public string NuNombre { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string NuApaterno { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string NuAmaterno { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string NuCorreo { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        [Range(100000000, 999999999, ErrorMessage = "Campo valido de 9 digitos")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public int IuCelular { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string NuDireccion { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirma Tu Contraseña")]
        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string NuContraseña { get; set; }
        public int FkIdTipoUsuario { get; set; }

        public TipoUsuario FkIdTipoUsuarioNavigation { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }
    }
}
