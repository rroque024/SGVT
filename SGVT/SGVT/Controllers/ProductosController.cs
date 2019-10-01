using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGVT.Models;
using SGVT.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.Data;
using System.Data.SqlClient;

namespace SGVT.Controllers
{
    public class ProductosController : Controller
    {
        private readonly BD_SGVTContext _context;
        private readonly IFileProvider _fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        

        public ProductosController(BD_SGVTContext context, IFileProvider fileprovider, IHostingEnvironment env)
        {
            _context = context;
            _fileProvider = fileprovider;
            _hostingEnvironment = env;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            ViewData["MainPath"] = Directory.GetCurrentDirectory();
            //ViewBag.IndexCatalogo= 
            return View(await _context.Producto.ToListAsync());
        }

        //Muestra en el catálogo
        public async Task<IActionResult> IndexCatalogo()
        {
            ViewData["MainPath"] = Directory.GetCurrentDirectory();
            //ViewBag.IndexCatalogo= 
            return View(await _context.Producto.ToListAsync());
        }




        //public List<Producto> ConsultarProducto() {

        //    SqlConnection conn = (SqlConnection)_context.Database.GetDbConnection();
        //    SqlCommand cmd = conn.CreateCommand();
        //    conn.Open();
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.CommandText = "sp_ConsultaProducto";
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    return 1;


        //}

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.PkIdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }
   
    // POST: Productos/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIdProducto,NpNombre,NpDescripcion,Imagen,EstadoProducto")] Producto producto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                if (file != null || file.Length != 0)
                {
                    FileInfo fi = new FileInfo(file.FileName);
                    var newFilename = producto.PkIdProducto + "_" + String.Format("{0:d}", (DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
                    var webPath = _hostingEnvironment.WebRootPath;
                    var path = Path.Combine("", webPath + @"\Catalogo\" + newFilename);
                    var pathToSave = @"/Catalogo/" + newFilename;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    producto.Imagen = pathToSave;
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }


        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIdProducto,NpNombre,NpDescripcion,Imagen,EstadoProducto")] Producto producto)
        {
            if (id != producto.PkIdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.PkIdProducto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.PkIdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.PkIdProducto == id);
        }
    }
}
