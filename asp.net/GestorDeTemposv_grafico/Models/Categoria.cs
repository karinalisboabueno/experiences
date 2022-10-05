using System.ComponentModel.DataAnnotations;

namespace GestorDeTempos.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Designação")]
        public string? Designacao { get; set; }


    }
}
