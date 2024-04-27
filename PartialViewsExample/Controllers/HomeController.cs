using Microsoft.AspNetCore.Mvc;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {

            ListModel Listmodel = new ListModel();
            Listmodel.ListTitle = "List of Items";
            Listmodel.ListItems = new List<string>()
            {
                "New York", "Egypt" , "Iraq"
            };

           return View(Listmodel);
        }

        [Route("about")]
        public IActionResult About()
        {

            ListModel Listmodel = new ListModel();
            Listmodel.ListTitle = "List of Items";
            Listmodel.ListItems = new List<string>()
            {
                "Masr", "Qena" , "Sohag"
            };
            return View(Listmodel);
        }
    }
}
