using InstaBurger.Data;
using InstaBurger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InstaBurger.Controllers
{
    public class FiltraCategoriaController : Controller
    {
        private readonly ApplicationDbContext db;

        public FiltraCategoriaController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(int? codCat, string? preferido, string? emStock, int? idLanche)
        {
            //criar select com as categorias
            var select = new SelectList(db.Categorias, "CategoriaId", "CategoriaNome");
            ViewBag.CATEGORIAS = select;

            // criar uma lista vazia do tipo lanche
            List<Lanche> lista = new List<Lanche>();

            // variavel com todos os resultados da tabela lanche
            var resultado = db.Lanches.Where(m => true);

            //guardar o valor da categoria selecionada
            ViewBag.codCat = codCat;

            //filtra pelo codigo da categoria que foi selecionado
            if (codCat != null)
            {
                resultado = resultado.Where(m => m.CategoriaId == codCat);
            }

            //se o campo preferido tiver selecionado, devolve apenas os preferidos 
            if (preferido != null && (preferido != "false"))
            {

                resultado = resultado.Where(c => c.IsLanchePreferido == true);
            }

            // se o campo emStock tiver selecionado, devolve apenas os que tiverem stock
            if (emStock != null)
            {

                resultado = resultado.Where(c => c.EmEstoque == (emStock == "sim"));
            }

            lista = resultado.ToList();
            

            // PedidoDetalhe
            if (idLanche > 0)
            {


                var pedidos = db.PedidoDetalhes.Where(c => c.LancheId == idLanche);

                var qt = pedidos.Sum(p => p.Quantidade);

                var preco = pedidos.Sum(p => p.Preco);


                Dictionary<string, Object> detalhePedido = new Dictionary<string, Object>();

                detalhePedido.Add("quantidade", qt);
                detalhePedido.Add("preco", preco);
                detalhePedido.Add("lancheId", idLanche);

                ViewBag.LANCHECLICADO = detalhePedido;

            }

            

            return View(lista);
        }
    }
}
