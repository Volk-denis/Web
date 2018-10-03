using NLog;
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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        WebContext webContext = new WebContext();

        public ActionResult Index()
        {
            
            IEnumerable<Book> books = webContext.Books;
            ViewBag.Books = books;

            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public string Buy(Pokupka pokupka)
        {
            pokupka.Date = DateTime.Now;
            webContext.Pokupki.Add(pokupka);
            webContext.SaveChanges();
            logger.Info("совершена покупка " + pokupka.PokupkaId);
            return "<h3>Спасибо за покупку</h3>";
            
        }

        public ActionResult Shou()
        {
            var a = webContext.Pokupki;
            ViewBag.Pokupki = a;
            ViewBag.Books = webContext.Books;
            return View();
        }


    }
}