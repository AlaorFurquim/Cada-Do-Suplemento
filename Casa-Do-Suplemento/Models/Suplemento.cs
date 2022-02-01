using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Casa_Do_Suplemento.Models
{
    [Table("Suplementos")]
    public class Suplemento
    {
        [Key]
        public int SuplementoId { get; set; }

        [Required(ErrorMessage = " O Nome Do Suplemento Deve Ser Informado")]
        [Display(Name = "Descrição do Suplemento")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "A Descrição Curta do Suplemento Deve Ser Informado")]
        [Display( Name = "Descrição detalhada do suplemento")]
        [MinLength(20, ErrorMessage ="Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200,ErrorMessage = "A descrição pode exceder até {1} caracteres")]

        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A Descrição Detalhada do Suplemento Deve ser Informado")]
        [Display(Name = "Descrição do suplemento")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição pode exceder até {1} caracteres")]

        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o Preço do Suplemento")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]

        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter nomáximo {1} caracteres")]

        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter nomáximo {1} caracteres")]

        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]

        public bool IsSuplementoFavorito { get; set; }


        [Display(Name = "Estoque?")]

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; } // chave estrangeira

        public virtual Categoria Categoria { get; set; } // propriedade de navegacao

    }
}
