using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;
using Casa_Do_Suplemento.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Casa_Do_Suplemento.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ISuplementoRepository _suplementoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ISuplementoRepository suplementoRepository, CarrinhoCompra carrinhoCompra)
        {
            _suplementoRepository = suplementoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {

            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        [Authorize]
        public IActionResult AdicionarNoCarrinhoCompra(int SuplementoId)
        {
            var suplementoSelecionado = _suplementoRepository.Suplementos.FirstOrDefault(p => p.SuplementoId == SuplementoId);
            if(suplementoSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(suplementoSelecionado);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverItemNoCarrinhoCompra(int SuplementoId)
        {
            var suplementoSelecionado = _suplementoRepository.Suplementos.FirstOrDefault(p => p.SuplementoId == SuplementoId);
            if (suplementoSelecionado != null)
            {
                _carrinhoCompra.RemoveDoCarrinho(suplementoSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
