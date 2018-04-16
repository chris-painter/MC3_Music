using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Context;

namespace MC3_Music.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDataContext _context;

        public HomeController()
        {
            _context = new ApplicationDataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var albums = _context.Albums.ToList();

            return View(albums);
        }
    }
}