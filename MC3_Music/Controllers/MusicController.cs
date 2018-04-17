﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;
using MC3_Music.Context;
using MC3_Music.ViewModels;
using System.Data.Entity;

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
            List<Album> inStockAlbums = new List<Album>();
            foreach(var a in albums)
            {
                if(a.Stock > 0)
                {
                    inStockAlbums.Add(a);
                }
            }
            return View(inStockAlbums);
        }

        public ActionResult SingleAlbum(int id)
        {
            var songs = _context.Songs.ToList();
            Album album = _context.Albums.SingleOrDefault(a => a.Id == id);

            var viewModel = new SingleAlbumViewModel
            {
                Album = album,
                Songs = songs
            };

            if (album == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }

        //public ActionResult getAlbum()
        //{
        //    return View("SingleAlbum");
        //}

        // GET: Music/Random
        public ActionResult Random() {
            var album = new Album() { Title = "Thriller", Genre = "Rock", Artist = "Michael Jackson" };

            return View(album);
        }

    }
}