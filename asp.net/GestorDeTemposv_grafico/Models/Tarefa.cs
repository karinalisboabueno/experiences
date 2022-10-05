using System.ComponentModel.DataAnnotations;

namespace GestorDeTempos.Models
{
   
    public class Tarefa
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Display(Name = "Data do Registo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DataRegisto { get; set; }

        //Chaves Estrangeiras
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }

        [Display(Name = "Funcionário")]
        public int FuncionarioId { get; set; }

        [Display(Name = "Funcionário")]
        public virtual Funcionario? Funcionario { get; set; }
    }
}
