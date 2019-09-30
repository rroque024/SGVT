using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGVT.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Pedido = new HashSet<Pedido>();
        }
        [Key]
        public int PkIdProducto { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string NpNombre { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public string NpDescripcion { get; set; }

        
        public string Imagen { get; set; }
        
        [Display(Name = "Estado ")]
        public bool? EstadoProducto { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
