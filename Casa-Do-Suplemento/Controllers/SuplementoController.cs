using Casa_Do_Suplemento.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Casa_Do_Suplemento.Controllers
{
    public class SuplementoController : Controller
    {
        private readonly ISuplementoRepository _suplementoRepository;

        public SuplementoController(ISuplementoRepository suplementoRepository)
        {
            _suplementoRepository = suplementoRepository;
        }

        public IActionResult List()
        {
            var suplementos = _suplementoRepository.Suplementos;
            return View(suplementos);
        }
    }
}
