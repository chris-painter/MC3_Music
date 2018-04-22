using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Models;
using MC3_Music.Context;
using MC3_Music.ViewModels;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using Microsoft.AspNet.Identity.Owin;

namespace MC3_Music.Controllers
{ 
    [Authorize]
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
            var customer = GetCustomer();

            var albums = _context.Albums.ToList();
            var cart = _context.Cart.ToList();


            var viewModel = new ShoppingCartViewModel
            {
                Albums = albums,
                Cart = cart,
                Customer = customer
            };

            return View("CartView", viewModel);
        }
       
        
        public ActionResult AddToCart(int id)
        {
            var customer = GetCustomer();

            Album album = _context.Albums.SingleOrDefault(a => a.Id == id);
            var c = _context.Cart.ToList();
            bool match = false;
            foreach (var e in c)
            {
                if (album.Id == e.Album_Id && customer == e.Customer)
                {
                    e.Quantity++;
                    match = true;
                    break;
                }
                else { }
            }
            if(match == false)
            {
                Cart cartItem = new Cart()
                {
                    Album = album,
                    Album_Id = album.Id,
                    Quantity = 1,
                    Customer = customer
                };
                _context.Cart.Add(cartItem);
            }
            else { }
            
            album.Stock--;
            _context.SaveChanges();

            var albums = _context.Albums.ToList();
            var cart = _context.Cart.ToList();


            var viewModel = new ShoppingCartViewModel
            {
                Albums = albums,
                Cart = cart,
                Customer = GetCustomer()
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

                Total = Total + (album.Price * item.Quantity);
            }
            return View("CartCheckout", Total);
        }

        public ActionResult Checkout()
        {
            var cart = _context.Cart.ToList();
            var customer = GetCustomer();
            foreach(var c in cart)
            {
                if (c.Customer == customer)
                {
                    var album = _context.Albums.SingleOrDefault(a => a.Id == c.Album_Id);

                    Transaction t = new Transaction
                    {
                        TransactionDate = DateTime.Now,
                        Quantity = c.Quantity,
                        Album_Id = c.Album_Id,
                        Customer = customer,
                        Price = album.Price
                    };

                    _context.Transactions.Add(t);
                    _context.Cart.Remove(c);
                    _context.SaveChanges();
                }
                else { }
                
            }
            return RedirectToAction("PaymentConfirmation", "Checkout");
        }

        public ActionResult PaymentConfirmation()
        {
            return View();
        }

        public Customer GetCustomer()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var userId = user.Id;
            var customer = _context.Customers.SingleOrDefault(a => a.UserId == userId);
            return customer;
        }

    }
}