using System;
using System.Collections.Generic;

namespace SGVT.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int PkIdProducto { get; set; }
        public string NpNombre { get; set; }
        public string NpDescripcion { get; set; }
        public string Imagen { get; set; }
        public bool? EstadoProducto { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
