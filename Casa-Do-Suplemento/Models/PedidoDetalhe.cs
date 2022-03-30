using System.ComponentModel.DataAnnotations.Schema;

namespace Casa_Do_Suplemento.Models
{
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }

        public int PedidoId { get; set; }

        public int SuplementoId { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Preco { get; set; }

        public virtual Suplemento Suplemento {get; set;}

        public virtual Pedido Pedido { get; set; }
    }
}
