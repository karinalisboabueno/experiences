using System.ComponentModel.DataAnnotations;

namespace GestorDeTempos.Models
{
    public class Tempo
    {
        public int Id { get; set; }

        [Display(Name = "Tempo em Minutos")]
        public int TempoemMin { get; set; }

        //Chaves Estrangeiras
        [Display(Name = "Tarefa")]
        public int TarefaId { get; set; }
        public virtual Tarefa? Tarefa { get; set; }
    }
}
