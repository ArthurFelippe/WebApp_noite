using Microsoft.AspNetCore.Mvc;

namespace WebApp_noite.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {

            return View();

        }
    }
}
