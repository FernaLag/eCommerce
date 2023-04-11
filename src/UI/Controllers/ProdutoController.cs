using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace UI.Controllers
{
    public class ProdutoController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        public ActionResult Edit(int id)
        {
            return View();
        }

         [HttpPost]
         [ValidateAntiForgeryToken]






        }





























    }
}
