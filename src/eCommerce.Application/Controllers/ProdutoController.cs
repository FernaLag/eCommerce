using eCommerce.Core.Services;
using eCommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace eCommerce.Application.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }
        public ActionResult Index()
        {
            var produtos = produtoService.GetProdutoList();
            return View(produtos);
        }

        [HttpGet]
        public ActionResult Detail()
        {
            var produto = produtoService.GetProduto(1);
            return View(produto);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                produtoService.CreateProduto(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var produto = produtoService.GetProduto(id);
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Produto produto)
        {

            try
            {
                produtoService.UpdateProduto(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id)
        {
            try
            {
                var produto = produtoService.GetProduto(id);
                produtoService.DeleteProduto(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
