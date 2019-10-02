using Microsoft.AspNetCore.Http;
using SGVT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SGVT.ViewModels
{
    public class ProductoCreateViewModel
    {
        public ProductoCreateViewModel()
        {
            Pedido = new HashSet<Pedido>();
        }
        [Required]
        public int PkIdProducto { get; set; }
        public string NpNombre { get; set; }
        public string NpDescripcion { get; set; }
        public IFormFile Imagen { get; set; }
        public bool? EstadoProducto { get; set; }

        public ICollection<Pedido> Pedido { get; set; }

        public interface IFormFile
        {
            string ContentType { get; }
            string ContentDisposition { get; }
            IHeaderDictionary Headers { get; }
            long Length { get; }
            string Name { get; }
            string FileName { get; }
            Stream OpenReadStream();
            void CopyTo(Stream target);
            //Task CopyToAsync(Stream target, CancellationToken cancellationToken= default);
        }
    }
}
