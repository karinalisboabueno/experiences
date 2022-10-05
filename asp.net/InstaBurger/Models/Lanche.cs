using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstaBurger.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }



        //validações data annotation
        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do Lanche")]
        //quantidade maxima e minima 
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição Curta")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no maximo {1} caracteres")]
        public string? DescricaoCurta { get; set; }



        [NotMapped]
        public DateTime DataDeCriacao { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição Detalhada")]
        //definir o minimo
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        //definir o maximo
        [MaxLength(200, ErrorMessage = "Descrição deve ter no maximo {1} caracteres")]
        public string? DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        //definir casas decimais do preço do lanche
        [Column(TypeName = "decimal(10,2)")]
        //limite de preço
        [Range(1, 999.99, ErrorMessage = "o preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho imagem normal")]
        //quantidade maxima e minima 
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no  no máximo {1} caracteres")]
        public string? ImagemUrl { get; set; }


        [Display(Name = "Caminho imagem miniatura")]
        //quantidade maxima e minima 
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no  no máximo {1} caracteres")]
        public string? ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //propriedades de navegação(chave estrangeira)
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

       
    }
}
