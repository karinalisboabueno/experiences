using System.ComponentModel.DataAnnotations;

namespace GestorDeTempos.Models
{
    public class ViewModelRelatorio
    {
        public Tarefa? Tarefa { get; set; }

        [Display(Name = "Tempo em Minutos")]
        public String? Tempo { get; set; }
        public int TempoEmMin { get; set; }

    }
}
