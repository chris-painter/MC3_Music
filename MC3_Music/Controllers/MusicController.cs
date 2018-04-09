using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;

namespace MC3_Music.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getAlbum()
        {
            return View("SingleAlbum");
        }

        // GET: Music/Random
        public ActionResult Random()
        {
            var album = new Album() { Title = "Thriller", Genre = Album.Genres.Rock, Artist = "Michael Jackson" };
            return View(album);
        }
    }
}