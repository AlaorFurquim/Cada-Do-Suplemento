using Casa_Do_Suplemento.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Casa_Do_Suplemento.Areas.Admin.Controllers
{

    [Area ("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminImagensController : Controller
    {
        private readonly ConfigurationImagens _myConfig;
        private readonly IWebHostEnvironment _HostingEnvironment;

        public AdminImagensController(IWebHostEnvironment hostingEnvironment,
            IOptions<ConfigurationImagens>myConfiguration)
        {
            _myConfig = myConfiguration.Value;
            _HostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
