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

            return View();

           /* if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }



            return Content("Hi from comics book controller. !!!"); */
        }

              
        
    }
}