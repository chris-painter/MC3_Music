using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;
using MC3_Music.Context;
using MC3_Music.ViewModels;

namespace MC3_Music.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDataContext _context;
        public List<Transaction> transactionCart = new List<Transaction>();


        public CheckoutController()
        {
            _context = new ApplicationDataContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
            // GET: Checkout
            public ActionResult Index()
        {
            return View();
        }

        public ActionResult CartView()
        {
            var albums = _context.Albums.ToList();
            var cart = _context.Cart.ToList();

            var viewModel = new ShoppingCartViewModel
            {
                Albums = albums,
                Cart = cart
            };

            return View("CartView", viewModel);
        }

        public ActionResult AddToCart(int id)
        {
            Album album = _context.Albums.SingleOrDefault(a => a.Id == id);
            Cart cartItem = new Cart()
            {
                Album = album,
                Quantity = 1          
            };

            album.Stock--;
            _context.Cart.Add(cartItem);
            _context.SaveChanges();

            var albums = _context.Albums.ToList();
            var cart = _context.Cart.ToList();

            var viewModel = new ShoppingCartViewModel
            {
                Albums = albums,
                Cart = cart
            };

            return View("CartView", viewModel);
        }

        public ActionResult RemoveAlbum(int id)
        {
            var cartItem = _context.Cart.SingleOrDefault(a => a.Id == id);

            Album album = _context.Albums.SingleOrDefault(a => a.Id == cartItem.Album_Id);
            album.Stock++;

            _context.Cart.Remove(cartItem);
            _context.SaveChanges();

            var albums = _context.Albums.ToList();
            var cart = _context.Cart.ToList();

            var viewModel = new ShoppingCartViewModel
            {
                Albums = albums,
                Cart = cart
            };

            return View("CartView", viewModel);
        }

        public ActionResult MoveToCheckOut()
        {
            var cart = _context.Cart.ToList();
            double Total = 0;
            foreach (var item in cart)
            {
                var album = _context.Albums.SingleOrDefault(a => a.Id == item.Album_Id);

                Total = Total + album.Price;
            }
            return View("CartCheckout", Total);
        }






    }
}