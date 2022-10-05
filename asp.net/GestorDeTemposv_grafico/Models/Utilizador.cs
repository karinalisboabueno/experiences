using System.ComponentModel.DataAnnotations;

namespace GestorDeTempos.Models
{
    public class Utilizador
    {
        public int Id { get; set; }

        [Display(Name = "Nome do utilizador")]
        public string? UtilizadorName { get; set; }
        [Display(Name = "Senha ou palavra-passe")]
        public string? Senha { get; set; }

    }
}
