using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        // action method - all public methods in a controller are action methods.
        public ActionResult Detail()
        {


            ViewBag.SeriesTitle = "The Amazing Spider Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue </p>";
            ViewBag.Artists = new string[]
            {
                "Script: DanSlot",
                "Pencils: Ramos"
            };

            return View();

           /* if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }



            return Content("Hi from comics book controller. !!!"); */
        }

              
        
    }
}