using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using eCommerce.Application.Models;
using eCommerce.Core.Services;
using eCommerce.Domain;

namespace eCommerce.Application.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ILogger<ManagerController> _logger;

        private readonly ProdutoService _produtoService;

        public ManagerController(ILogger<ManagerController> logger, ProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }
        public IActionResult Manager()
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