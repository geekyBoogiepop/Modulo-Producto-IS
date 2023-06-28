using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modulo_Producto.Data;
using Modulo_Producto.Models;

namespace Modulo_Producto
{
    public class VentasController : Controller
    {
        private readonly SQLiteContext _context;

        public VentasController(SQLiteContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
              return _context.Venta != null ? 
                          View(await _context.Venta.ToListAsync()) :
                          Problem("Entity set 'SQLiteContext.Venta'  is null.");
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Venta == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            List<Producto> productList = _context.Producto.ToList();
            ViewBag.ProductList = new SelectList(productList, "Id", "CodigoBarra");
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Cantidad,Caja,IdProducto")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                var product = await _context.Producto.FindAsync(venta.IdProducto);
                venta.Total = product.PrecioCosto * venta.Cantidad;
                _context.Add(venta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venta);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            List<Producto> productList = _context.Producto.ToList();
            ViewBag.ProductList = new SelectList(productList, "Id", "CodigoBarra");

            if (id == null || _context.Venta == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }
            return View(venta);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Cantidad,Caja,IdProducto")] Venta venta)
        {
            if (id != venta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var product = await _context.Producto.FindAsync(venta.IdProducto);
                    venta.Total = product.PrecioCosto * venta.Cantidad;
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(venta.Id))
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
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Venta == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Venta == null)
            {
                return Problem("Entity set 'SQLiteContext.Venta'  is null.");
            }
            var venta = await _context.Venta.FindAsync(id);
            if (venta != null)
            {
                _context.Venta.Remove(venta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaExists(int id)
        {
          return (_context.Venta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
