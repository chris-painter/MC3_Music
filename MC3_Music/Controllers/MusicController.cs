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

        public ActionResult SingleAlbum()
        {
            return View();
        }

        //public ActionResult getAlbum()
        //{
        //    return View("SingleAlbum");
        //}

        // GET: Music/Random
        public ActionResult Random()
        {
            List<string> songs = new List<string>();
            songs.Add("Thriller");
            songs.Add("Beat It");
            songs.Add("Bad");

            var album = new Album() { Title = "Thriller", Genre = Album.Genres.Rock, Artist = "Michael Jackson", Songs = songs};

            return View(album);
        }
    }
}