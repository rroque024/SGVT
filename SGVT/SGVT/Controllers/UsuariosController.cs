﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGVT.Models;

namespace SGVT.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly BD_SGVTContext _context;

        public UsuariosController(BD_SGVTContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var bD_SGVTContext = _context.Usuario.Include(u => u.FkIdTipoUsuarioNavigation);
            return View(await bD_SGVTContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.FkIdTipoUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.PkDni == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["FkIdTipoUsuario"] = new SelectList(_context.TipoUsuario, "PkIdTipoUsuario", "PkIdTipoUsuario");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkDni,NuNombre,NuApaterno,NuAmaterno,NuCorreo,IuCelular,NuDireccion,NuContraseña,FkIdTipoUsuario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkIdTipoUsuario"] = new SelectList(_context.TipoUsuario, "PkIdTipoUsuario", "PkIdTipoUsuario", usuario.FkIdTipoUsuario);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["FkIdTipoUsuario"] = new SelectList(_context.TipoUsuario, "PkIdTipoUsuario", "PkIdTipoUsuario", usuario.FkIdTipoUsuario);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkDni,NuNombre,NuApaterno,NuAmaterno,NuCorreo,IuCelular,NuDireccion,NuContraseña,FkIdTipoUsuario")] Usuario usuario)
        {
            if (id != usuario.PkDni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.PkDni))
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
            ViewData["FkIdTipoUsuario"] = new SelectList(_context.TipoUsuario, "PkIdTipoUsuario", "PkIdTipoUsuario", usuario.FkIdTipoUsuario);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.FkIdTipoUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.PkDni == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.PkDni == id);
        }
    }
}
