using Casa_Do_Suplemento.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Casa_Do_Suplemento.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRelatorioVendasController : Controller
    {
        private readonly RelatorioVendasService relatorioVendasService;

        public AdminRelatorioVendasController(RelatorioVendasService relatorioVendasService)
        {
            this.relatorioVendasService = relatorioVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RelatorioVendasSimples(DateTime?minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!minDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyyy-MM-dd");

            var result = await relatorioVendasService.FindByDateAsync(minDate,maxDate);
            return View(result);
        }
    }
}
