using App4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App4.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarPessoa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPessoa(Pessoa objPessoa)
        {
            if (ModelState.IsValid) 
            {
                return View("Resultado", objPessoa);
            }
            return View();
          
        }
        public IActionResult Resultado()
        {
            return View();
        }


        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto objProduto)
        {
            if (ModelState.IsValid)
            {
                return View("Exibir", objProduto);
            }
            return View();

        }
        public IActionResult Exibir()
        {
            return View();
        }




        //public IActionResult Privacy()
        //{
        //  return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
