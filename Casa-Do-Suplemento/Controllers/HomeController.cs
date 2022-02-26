using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories;
using Casa_Do_Suplemento.Repositories.Interfaces;
using Casa_Do_Suplemento.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Casa_Do_Suplemento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISuplementoRepository _suplementoRepository;

        public HomeController(ISuplementoRepository suplementoRepository)
        {
            _suplementoRepository = suplementoRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SuplementosPreferidos = _suplementoRepository.SuplementosPreferidos
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}