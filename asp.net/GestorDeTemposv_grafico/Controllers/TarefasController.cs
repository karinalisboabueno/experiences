using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorDeTempos.Data;
using GestorDeTempos.Models;
using Microsoft.AspNetCore.Authorization;

namespace GestorDeTempos.Controllers
{
    [BasicAuthorize]
    public class TarefasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        // GET: Tarefas
        public async Task<IActionResult> Index(int id)
        {
            var applicationDbContext = _context.TTarefas.Include(t => t.Categoria).Include(t => t.Cliente).Include(t => t.Funcionario);



            return View(await applicationDbContext.ToListAsync());
        }
        [AllowAnonymous]
        // GET: Tarefas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TTarefas == null)
            {
                return NotFound();
            }

            var tarefa = await _context.TTarefas
                .Include(t => t.Categoria)
                .Include(t => t.Cliente)
                .Include(t => t.Funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }
        [AllowAnonymous]
        // GET: Tarefas/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.TCategorias, "Id", "Designacao");
            ViewData["ClienteId"] = new SelectList(_context.TClientes, "Id", "Nome");
            ViewData["FuncionarioId"] = new SelectList(_context.TFuncionarios, "Id", "Nome");
            return View();
        }
        [AllowAnonymous]
        // POST: Tarefas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,DataRegisto,CategoriaId,ClienteId,FuncionarioId")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.TCategorias, "Id", "Id", tarefa.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.TClientes, "Id", "Id", tarefa.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_context.TFuncionarios, "Id", "Id", tarefa.FuncionarioId);
            return View(tarefa);
        }

        // GET: Tarefas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TTarefas == null)
            {
                return NotFound();
            }

            var tarefa = await _context.TTarefas.FindAsync(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.TCategorias, "Id", "Designacao", tarefa.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.TClientes, "Id", "Nome", tarefa.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_context.TFuncionarios, "Id", "Nome", tarefa.FuncionarioId);
            return View(tarefa);
        }

        // POST: Tarefas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,DataRegisto,CategoriaId,ClienteId,FuncionarioId")] Tarefa tarefa)
        {
            if (id != tarefa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tarefa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TarefaExists(tarefa.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.TCategorias, "Id", "Id", tarefa.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.TClientes, "Id", "Id", tarefa.ClienteId);
            ViewData["FuncionarioId"] = new SelectList(_context.TFuncionarios, "Id", "Id", tarefa.FuncionarioId);
            return View(tarefa);
        }

        // GET: Tarefas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TTarefas == null)
            {
                return NotFound();
            }

            var tarefa = await _context.TTarefas
                .Include(t => t.Categoria)
                .Include(t => t.Cliente)
                .Include(t => t.Funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }

        // POST: Tarefas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TTarefas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TTarefas'  is null.");
            }
            var tarefa = await _context.TTarefas.FindAsync(id);
            if (tarefa != null)
            {
                _context.TTarefas.Remove(tarefa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarefaExists(int id)
        {
            return (_context.TTarefas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
