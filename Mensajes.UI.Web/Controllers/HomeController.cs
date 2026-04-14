using Mensajes.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mensajes.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BL.GestorMensaje gm = new BL.GestorMensaje();
            var dataList = new List<string> { "Item 1", "Item 2", "Item 3" };
            ViewData["Message"] = "Hello from ViewData!";
            ViewBag.Msg = "Hello from ViewBag!";
            return View("Index", gm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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
