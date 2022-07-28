using Question2.AshutoshNayak.eClerx.ModuleTest_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Question2.AshutoshNayak.eClerx.ModuleTest_4.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public BooksController()
        {
            _dbContext = new ApplicationDbContext();
        }
       // GET: Products
        public ActionResult Index()
        {
            //var books = GetBooks();
            var books = _dbContext.Books.ToList();
            return View(books);
        }

        //GET
        public ActionResult Details(int id)
        {
            var product = _dbContext.Books.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }
        public ActionResult Create()
        {
            return View();
        }
        //public List<BookDetails> GetBooks()
        //{
        //    return new List<BookDetails>
        //    {
        //        new BookDetails { Id = 1, ISBN = "ST1234", BookName = "Champak", Genre = "Story Book", AuthorName = "Champak" },
        //    };
        //}
    }
}