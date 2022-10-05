using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstaBurger.Data;
using InstaBurger.Models;

namespace InstaBurger.Controllers
{
    public class PedidoDetalhesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoDetalhesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PedidoDetalhes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PedidoDetalhes.Include(p => p.Lanche).Include(p => p.Pedido);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PedidoDetalhes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PedidoDetalhes == null)
            {
                return NotFound();
            }

            var pedidoDetalhe = await _context.PedidoDetalhes
                .Include(p => p.Lanche)
                .Include(p => p.Pedido)
                .FirstOrDefaultAsync(m => m.PedidoDetalheId == id);
            if (pedidoDetalhe == null)
            {
                return NotFound();
            }

            return View(pedidoDetalhe);
        }

        // GET: PedidoDetalhes/Create
        public IActionResult Create()
        {
            ViewData["LancheId"] = new SelectList(_context.Lanches, "LancheId", "LancheId");
            ViewData["PedidoId"] = new SelectList(_context.Pedidos, "PedidoId", "PedidoId");
            return View();
        }

        // POST: PedidoDetalhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PedidoDetalheId,PedidoId,LancheId,Quantidade,Preco")] PedidoDetalhe pedidoDetalhe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoDetalhe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LancheId"] = new SelectList(_context.Lanches, "LancheId", "LancheId", pedidoDetalhe.LancheId);
            ViewData["PedidoId"] = new SelectList(_context.Pedidos, "PedidoId", "PedidoId", pedidoDetalhe.PedidoId);
            return View(pedidoDetalhe);
        }

        // GET: PedidoDetalhes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PedidoDetalhes == null)
            {
                return NotFound();
            }

            var pedidoDetalhe = await _context.PedidoDetalhes.FindAsync(id);
            if (pedidoDetalhe == null)
            {
                return NotFound();
            }
            ViewData["LancheId"] = new SelectList(_context.Lanches, "LancheId", "LancheId", pedidoDetalhe.LancheId);
            ViewData["PedidoId"] = new SelectList(_context.Pedidos, "PedidoId", "PedidoId", pedidoDetalhe.PedidoId);
            return View(pedidoDetalhe);
        }

        // POST: PedidoDetalhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PedidoDetalheId,PedidoId,LancheId,Quantidade,Preco")] PedidoDetalhe pedidoDetalhe)
        {
            if (id != pedidoDetalhe.PedidoDetalheId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoDetalhe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoDetalheExists(pedidoDetalhe.PedidoDetalheId))
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
            ViewData["LancheId"] = new SelectList(_context.Lanches, "LancheId", "LancheId", pedidoDetalhe.LancheId);
            ViewData["PedidoId"] = new SelectList(_context.Pedidos, "PedidoId", "PedidoId", pedidoDetalhe.PedidoId);
            return View(pedidoDetalhe);
        }

        // GET: PedidoDetalhes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PedidoDetalhes == null)
            {
                return NotFound();
            }

            var pedidoDetalhe = await _context.PedidoDetalhes
                .Include(p => p.Lanche)
                .Include(p => p.Pedido)
                .FirstOrDefaultAsync(m => m.PedidoDetalheId == id);
            if (pedidoDetalhe == null)
            {
                return NotFound();
            }

            return View(pedidoDetalhe);
        }

        // POST: PedidoDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PedidoDetalhes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PedidoDetalhes'  is null.");
            }
            var pedidoDetalhe = await _context.PedidoDetalhes.FindAsync(id);
            if (pedidoDetalhe != null)
            {
                _context.PedidoDetalhes.Remove(pedidoDetalhe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoDetalheExists(int id)
        {
          return (_context.PedidoDetalhes?.Any(e => e.PedidoDetalheId == id)).GetValueOrDefault();
        }
    }
}
