using Casa_Do_Suplemento.Models;

namespace Casa_Do_Suplemento.ViewModels
{
    public class PedidoSuplementoViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidosDetalhes { get; set; } 
    }
}
