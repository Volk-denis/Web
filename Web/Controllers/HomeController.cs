using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        WebContext webContext = new WebContext();

        public ActionResult Index()
        {
            IEnumerable<Book> books = webContext.Books;
            ViewBag.Books = books;

            return View();
        }

        
    }
}