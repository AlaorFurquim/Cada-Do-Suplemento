using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Casa_Do_Suplemento.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0;

            //obtem os itens do carrinho de compra

            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = items;

            //verifica se existem itens de pedido

            if(_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho de compra está vazio, vamos adicionar um suplemento?");
            }

            //calcula o total de itens e total do pedido

            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Suplemento.Preco * item.Quantidade);
            }

            //atribui os valores obtidos ao pedido
            pedido.TotalItensPedido = totalItensPedido;
            pedido.PedidoTotal = precoTotalPedido;

            //valida os dados do pedido

            if (ModelState.IsValid)
            {
                //cria os pedidos e os detalhes
                _pedidoRepository.CriandoPedido(pedido);

                //define mensagens ao cliente
                ViewBag.CheckoutCompletoMesagem = "Obrigado pela sua compra!";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                //limpa carrinho
                _carrinhoCompra.LimpaCarrinho();

                //exibe a view com dados do cliente e do pedido
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);

            }

            return View(pedido);

        }

    }
}
