using Casa_Do_Suplemento.Context;
using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;

namespace Casa_Do_Suplemento.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriandoPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;
            foreach (var carrinhoCompra in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoCompra.Quantidade,
                    SuplementoId = carrinhoCompra.Suplemento.SuplementoId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoCompra.Suplemento.Preco
                };

                _appDbContext.PedidoDetalhes.Add(pedidoDetail); 
            }
            _appDbContext.SaveChanges();
        }
    }
}
