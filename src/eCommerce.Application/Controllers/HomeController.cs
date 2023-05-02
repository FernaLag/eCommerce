using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using eCommerce.Application.Models;
using eCommerce.Core.Services;

namespace eCommerce.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProdutoService _produtoService;

        public HomeController(ILogger<HomeController> logger, ProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            var produtos = _produtoService.GetProdutoList();
            return View(produtos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}