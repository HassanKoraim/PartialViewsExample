using Microsoft.AspNetCore.Mvc;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {

            //ListModel Listmodel = new ListModel();
            //Listmodel.ListTitle = "List of Items";
            //Listmodel.ListItems = new List<string>()
            //{
            //    "New York", "Egypt" , "Iraq"
            //};

           return View();
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
        [Route("Programming-Languages")]
        public IActionResult ProgrammingLanguages()
        {
            ListModel listModel = new ListModel()
            {
                ListTitle = "Programming Languages List",
                ListItems = new List<string>()
                {
                    "Python",
                    "C++",
                    "C#"
                }
            };
            return PartialView("_ListPartialView", listModel);
            
            // or this
            // return new PartialViewResult() { ViewName = "_ListPartialView", Model = listModel };
        }
    }
}
