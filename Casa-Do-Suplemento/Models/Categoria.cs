using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Casa_Do_Suplemento.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]  
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage = "O Tamanho Máximo é de 100 Caracteres")]
        [Required(ErrorMessage = "Informe um Nome de Categoria")]
        [Display(Name = "Nome")]

        public string CategoriaName { get; set; }

        [StringLength(200, ErrorMessage = "O Tamanho Máximo é de 200 Caracteres")]
        [Required(ErrorMessage = "Informe uma descrição")]
        [Display(Name = "Descricao")]

        public string Descricao { get; set; }

        public List<Suplemento> Suplementos { get; set; } //relacionamento de um para muito 
        
    }
}
