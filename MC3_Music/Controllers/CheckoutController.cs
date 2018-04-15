using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;
using MC3_Music.Context;

namespace MC3_Music.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDataContext _context;
        List<Transaction> transactionCart = new List<Transaction>();


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
            Transaction transaction = new Transaction()
            {
                Album = album,
                TransactionDate = DateTime.Now
            };
            transactionCart.Add(transaction);
            
            return View("CartView", transactionCart);
        }
    }
}