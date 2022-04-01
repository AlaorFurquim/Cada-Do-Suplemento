using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;
using Casa_Do_Suplemento.ViewModels;
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

        public IActionResult List(string categoria)
        {
            IEnumerable<Suplemento> suplementos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                suplementos = _suplementoRepository.Suplementos.OrderBy(l => l.SuplementoId);
                categoriaAtual = "Todos os suplementos";
            }
            else
            {
               
                
                    suplementos = _suplementoRepository.Suplementos
                        .Where(l => l.Categoria.CategoriaName.Equals(categoria))
                        .OrderBy(l => l.Nome);
                

                categoriaAtual = categoria;
            }

            var suplementosListViewModel = new SuplementoListViewModel
            {
                Suplementos = suplementos,
                CategoriaAtual = categoriaAtual
            };

            return View(suplementosListViewModel);
        }

        public IActionResult Details (int suplementoId)
        {
            var suplemento = _suplementoRepository.Suplementos.FirstOrDefault(l => l.SuplementoId == suplementoId);
            return View(suplemento);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Suplemento> suplementos;
            string categoraiaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                suplementos = _suplementoRepository.Suplementos.OrderBy(p => p.SuplementoId);
                categoraiaAtual = "Todos os suplementos";
            }
            else
            {
                suplementos = _suplementoRepository.Suplementos
                    .Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

                if (suplementos.Any())
                    categoraiaAtual = "suplementos";
                else
                    categoraiaAtual = "Nenhum suplemento localizado";
            }

            return View("~/Views/Suplemento/List.cshtml", new SuplementoListViewModel
            {
                Suplementos = suplementos,
                CategoriaAtual = categoraiaAtual
            }) ;
        }

    }

}
