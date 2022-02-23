using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;
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
            return View();
        }

    }
}
