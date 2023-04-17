using Microsoft.AspNetCore.Mvc;
using MVCWallBuilder.Models;

namespace MVCWallBuilder.Controllers
{
    public class FrontController : Controller
    {
        // list with all layouts of created wall
        private static List<WallLayoutViewModel> wallLayouts = new List<WallLayoutViewModel>();

        public IActionResult Index()
        {
            return View(wallLayouts);
        }
        // display the form
        public IActionResult Create()
        {
            var wallLayVm = new WallLayoutViewModel();
            return View(wallLayVm);
        }
        // bound with view
        public IActionResult CreateLayer(WallLayoutViewModel layoutViewModel)
        {
           // add the new layer to the list
           wallLayouts.Add(layoutViewModel);
           return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Here return smth";
        }

    }
}
