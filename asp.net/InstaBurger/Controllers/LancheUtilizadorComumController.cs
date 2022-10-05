using InstaBurger.Data;
using InstaBurger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InstaBurger.Controllers
{
    public class LancheUtilizadorComumController : Controller
    {
        private readonly ApplicationDbContext db;

        public LancheUtilizadorComumController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Lanche> lista = new List<Lanche>();

            lista = db.Lanches.ToList();

            return View(lista);
        }
       
        public IActionResult Details(int? lancheId)
        {
            var lanche= db.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return View(lanche);
        }
    }
}
