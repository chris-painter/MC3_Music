using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;
using MC3_Music.Context;

namespace MC3_Music.Controllers
{
    public class MusicController : Controller
    {
        private ApplicationDataContext _context;

        public MusicController()
        {
            _context = new ApplicationDataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Music
        public ActionResult Index()
        {
            var albums = _context.Albums.ToList();

            return View(albums);
        }

        public ActionResult SingleAlbum(int id)
        {
            Album album = _context.Albums.SingleOrDefault(a => a.Id == id);

            if(album == null)
            {
                return HttpNotFound();
            }

            return View(album);
        }

        public ActionResult getAlbum()
        {
            return View("SingleAlbum");
        }

        // GET: Music/Random
        public ActionResult Random()
        {
            var album = new Album() { Title = "Thriller", Genre = "Rock", Artist = "Michael Jackson" };
            return View(album);
        }

    }
}