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
        public string  Detail()
        {
            return

                "Hi from comics book controller. !!! "; 
        }
    }
}