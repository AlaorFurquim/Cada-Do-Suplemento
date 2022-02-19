using System.ComponentModel.DataAnnotations;

namespace Casa_Do_Suplemento.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }

        public Suplemento Suplemento { get; set; }

        public int Quantidade { get; set; }

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
