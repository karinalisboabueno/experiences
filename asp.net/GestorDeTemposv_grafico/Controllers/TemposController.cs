using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorDeTempos.Data;
using GestorDeTempos.Models;

namespace GestorDeTempos.Controllers
{
    public class TemposController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TemposController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Tempos
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ID = id;

            //inclui o where para buscar o id da chave estrangeira
            var applicationDbContext = _context.TTempos.Include(t => t.Tarefa).Where(t => t.TarefaId == id);

       
            //ViewBag.DESCRICAOTAREFA = BuscaDescricao(id);
          

            var sum = _context.TTempos.Where(c => c.TarefaId == id).Sum(s => s.TempoemMin);
            ViewBag.HORA = TimeSpan.FromMinutes(sum).ToString("c");
            ViewBag.MINUTO = Convert.ToDecimal(sum);

            
            return View(await applicationDbContext.ToListAsync());
        }

        //private string BuscaDescricao(int? id)
        //{
        //    Tarefa descricao = new Tarefa();

        //    string s = "";

        //    descricao = _context.TTarefas.Find(id);

        //    s = descricao.Descricao;

        //    return s;
        //}

       


        // GET: Tempos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TTempos == null)
            {
                return NotFound();
            }

            var tempo = await _context.TTempos
                .Include(t => t.Tarefa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tempo == null)
            {
                return NotFound();
            }

            return View(tempo);
        }

        // GET: Tempos/Create
        public IActionResult Create(int? id)
        {
            ViewBag.ID = id;
            ViewData["TarefaId"] = new SelectList(_context.TTarefas, "Id", "Descricao");
            
            return View();
        }

        // POST: Tempos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTempos([Bind("Id,TempoemMin,TarefaId")] Tempo tempo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tempo);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index), new { @id = tempo.TarefaId });
            }
            ViewData["TarefaId"] = new SelectList(_context.TTarefas, "Id", "Descricao", tempo.TarefaId);
            return View(tempo);
        }

        // GET: Tempos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TTempos == null)
            {
                return NotFound();
            }

            var tempo = await _context.TTempos.FindAsync(id);
            if (tempo == null)
            {
                return NotFound();
            }
            ViewData["TarefaId"] = new SelectList(_context.TTarefas, "Id", "Descricao", tempo.TarefaId);
            return View(tempo);
        }

        // POST: Tempos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TempoemMin,TarefaId")] Tempo tempo)
        {
            if (id != tempo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tempo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TempoExists(tempo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new {@id = tempo.TarefaId}); //acrescentar new para voltar 
            }
            ViewData["TarefaId"] = new SelectList(_context.TTarefas, "Id", "Descricao", tempo.TarefaId);
            return View(tempo);
        }

        // GET: Tempos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TTempos == null)
            {
                return NotFound();
            }

            var tempo = await _context.TTempos
                .Include(t => t.Tarefa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tempo == null)
            {
                return NotFound();
            }

            return View(tempo);
        }

        // POST: Tempos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TTempos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TTempos'  is null.");
            }
            var tempo = await _context.TTempos.FindAsync(id);
            if (tempo != null)
            {
                _context.TTempos.Remove(tempo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TempoExists(int id)
        {
            return (_context.TTempos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
