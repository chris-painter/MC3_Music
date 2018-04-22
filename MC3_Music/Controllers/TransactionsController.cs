using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MC3_Music.Context;
using MC3_Music.Models;
using MC3_Music.ViewModels;

namespace MC3_Music.Controllers
{
    public class TransactionsController : Controller
    {
        private ApplicationDataContext _context;

        public TransactionsController()
        {
            _context = new ApplicationDataContext();
        }

        // GET: Transactions
        public ActionResult Index()
        {

            var albums = _context.Albums.ToList();
            var transactions = _context.Transactions.ToList();
            var genre = _context.Albums.ToList();
            var stock = _context.Albums.ToList();
            var year = _context.Transactions.ToList();


            var viewModel = new TransactionViewModel
            {
                Albums = albums,
                Transactions = transactions,
            };
            

            return View(viewModel);
        }

        public ActionResult Report()
        {
            return View();
            //return RedirectToAction("Index", "Transactions");

        }


        //public async System.Threading.Tasks.Task<ActionResult> numSoldAsync(int? id)
        //{
        //    string query = "SELECT Count(Quantity) FROM Transactions";
        //    Transaction transaction = await _context.Transactions.SqlQuery(query, id).SingleOrDefaultAsync();

        //    return View(transaction);
        //}

        // GET: Transactions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = _context.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // GET: Transactions/Create
        public ActionResult Create()
        {
            ViewBag.Album_Id = new SelectList(_context.Albums, "Id", "Title");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Album_Id,Quantity,TransactionDate,Price")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Album_Id = new SelectList(_context.Albums, "Id", "Title", transaction.Album_Id);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = _context.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            ViewBag.Album_Id = new SelectList(_context.Albums, "Id", "Title", transaction.Album_Id);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Album_Id,Quantity,TransactionDate,Price")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(transaction).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Album_Id = new SelectList(_context.Albums, "Id", "Title", transaction.Album_Id);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = _context.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaction transaction = _context.Transactions.Find(id);
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
