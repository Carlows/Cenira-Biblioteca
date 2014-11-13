using CeniraBiblioteca.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CeniraBiblioteca.Models;
using System.Collections;
using PagedList;
using CeniraBiblioteca.Models.Repositories;

namespace CeniraBiblioteca.Controllers
{
    public class HomeController : Controller
    {
        CeniraContext db = new CeniraContext();
        PedidosRepository repo = new PedidosRepository();

        public ActionResult Index()
        {
            var cats = db.Categories.Include(b => b.Books).ToList();
            var model = cats
            .Select(c => new Category
                           {
                               CategoryName = c.CategoryName,
                               Books = c.Books.Take(4).ToList()
                           })
                           .ToList();

            return View(model);
        }

        public ActionResult Search(string category, string currentFilter, string searchString, int page = 1)
        {
            List<Book> books = new List<Book>();

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = db.Books.ToList();
                books = books.Where(b => b.Name.ToUpper().Contains(searchString.ToUpper())
                                       || b.Author.ToUpper().Contains(searchString.ToUpper())
                                       || b.Category.CategoryName.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            else if(!String.IsNullOrEmpty(category))
            {
                books = db.Books.ToList();
                books = books.Where(b => b.Category.CategoryName.ToUpper().Contains(category.ToUpper())).ToList();
            }

            int pageSize = 6;
            int pageNumber = page;
            return View(books.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Team()
        {
            return View();
        }

        // Obtiene un libro segun el id pasado en el parametro
        private Book GetABook(int bookID)
        {
            IEnumerable<Book> books = db.Books.ToList();

            return books.Where(b => b.BookID == bookID).Single();
        }

        /* 
         * Devuelve una lista parcial con el libro especificado segun su id
         * 
         * */
        public ActionResult GetBook(int id)
        {
            Book book = GetABook(id);
            return PartialView(book);
        }

        public ActionResult PedirLibro(int id)
        {
            Pedidos pedido = new Pedidos
            {
                ID = 0,
                BookID = id
            };
            return View(pedido);
        }

        [HttpPost]
        public ActionResult PedirLibro(Pedidos pedido)
        {
            //Book bk = db.Books
            //.FirstOrDefault(b => b.BookID == pedido.idLibro);
            //pedido.book = bk;
            if (ModelState.IsValid)
            {
                //pedido.book = null;
                repo.SavePedido(pedido);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(pedido);
            }
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}