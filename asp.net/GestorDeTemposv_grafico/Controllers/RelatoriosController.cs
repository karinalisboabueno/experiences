using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorDeTempos.Data;
using GestorDeTempos.Models;

namespace GestorDeTempos.Controllers
{
   
    public class RelatoriosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RelatoriosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(DateTime? minDate, DateTime? maxDate, int Idfuncionario, int Idcliente)
        {
           //datepicker min e max

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            

            var resultado  = _db.TTarefas.Where(a=>true);

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.DataRegisto >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.DataRegisto <= maxDate.Value);
            }



            //filtra pelo codigo do funcionario que foi selecionado
            if (Idfuncionario!=0)
            {
                resultado = resultado.Where(t => t.FuncionarioId == Idfuncionario);
            }

            //filtra pelo codigo do cliente que foi selecionado
            if (Idcliente != 0)
            {
                resultado = resultado.Where(t => t.ClienteId == Idcliente);
            }

            //resultado é a Ttarefa e agora com includes das chaves estrangeiras para ter acesso
            resultado = resultado.Include(t => t.Categoria).Include(t => t.Cliente).Include(t => t.Funcionario);



            // criar uma lista vazia do tipo ViewModelRelatorio
            List<ViewModelRelatorio> lista = new List<ViewModelRelatorio>();
            //percorrer resultado 
            foreach (var item in resultado.ToList())
            {
                //instaciar viewmodelrelatorio para obter Ttarefa e Ttempo
                ViewModelRelatorio re = new ViewModelRelatorio();
                re.Tarefa = item;
                var tempoEmMin = _db.TTempos.Where(t => t.TarefaId == item.Id).Sum(t => t.TempoemMin);
                re.Tempo = TimeSpan.FromMinutes(tempoEmMin).ToString("c");
                re.TempoEmMin = tempoEmMin;
                lista.Add(re);
            }

            //criar select com funcionarios
            SelectList funcionario = new SelectList(_db.TFuncionarios, "Id", "Nome");
            ViewBag.FUNCIONARIO = funcionario;

            //criar select com clientes
            SelectList cliente = new SelectList(_db.TClientes, "Id", "Nome");
            ViewBag.CLIENTE = cliente;


            ViewBag.FUNCIONARIOS_JSON = JsonSerializer.Serialize(funcionario);
            
            ViewBag.TAREFAS_JSON = JsonSerializer.Serialize(lista);

            //retorna lista
            return View(lista);
        }
    }
}
