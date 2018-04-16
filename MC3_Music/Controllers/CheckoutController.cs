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

        public ActionResult CartView(List<Transaction> cart)
        {
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            Album album = _context.Albums.SingleOrDefault(a => a.Id == id);
            Cart cartItem = new Cart()
            {
                Album = album,
                Quantity = 1          
            };

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
    }
}