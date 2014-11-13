using CeniraBiblioteca.Models;
using CeniraBiblioteca.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CeniraBiblioteca.Models.Repositories;

namespace CeniraBiblioteca.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        BookRepository repository = new BookRepository();
        CatRepository catRepo = new CatRepository();
        PedidosRepository pedidosRepo = new PedidosRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Libros()
        {
            return View(repository.db.Books.ToList());
        }

        public ActionResult Categorias()
        {
            return View(catRepo.db.Categories.ToList());
        }

        public ActionResult Pedidos()
        {
            return View(pedidosRepo.db.Pedidos.ToList());
        }

        public ActionResult EditCat(int id)
        {
            Category cat = catRepo.db.Categories
                            .FirstOrDefault(c => c.CategoryID == id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult EditCat(Category cat)
        {
            if(ModelState.IsValid)
            {
                catRepo.SaveCategory(cat);
                TempData["message"] = string.Format("{0} guardada correctamente.", cat.CategoryName);
                return RedirectToAction("Categorias");
            }
            else
            {
                return View(cat);
            }
        }

        public ActionResult CreateCat()
        {
            return View("EditCat", new Category());
        }

        [HttpPost]
        public ActionResult DeleteCat(int id = 0)
        {
            if (id == 0)
            {
                TempData["message"] = string.Format("La categoria no existe");
                return RedirectToAction("Categorias");
            }
            else
            {

                Category deletedCategory = catRepo.DeleteCategory(id);
                if (deletedCategory != null)
                {
                    TempData["message"] = string.Format("{0} borrada correctamente",
                    deletedCategory.CategoryName);
                }
                return RedirectToAction("Categorias");
            }
        }

        public ActionResult EditBook(int id)
        {
            Book book = repository.db.Books
            .FirstOrDefault(b => b.BookID == id);

            List<string> categories = (from repo in repository.db.Categories
                             select repo.CategoryName).ToList();

            BookViewModel model = new BookViewModel
            {
                book = book,
                categories = categories
            };

            ViewBag.Create = false;

            return View(model);
        }

        [HttpPost]
        public ActionResult EditBook(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = model.book;
                book.CategoryID = repository.db.Categories.ToList().Single(c => c.CategoryName == model.category).CategoryID;

                repository.SaveBook(book);
                TempData["message"] = string.Format("{0} guardado correctamente.", book.Name);
                return RedirectToAction("Libros");
            }
            else
            {
                // there is something wrong with the data values
                return View(model);
            }
        }

        public ActionResult CreateBook()
        {
            BookViewModel model = new BookViewModel
            {
                book = new Book(),
                categories = (from repo in repository.db.Categories
                              select repo.CategoryName).ToList()
            };

            ViewBag.Create = true;

            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult DeleteBook(int id = 0)
        {
            if (id == 0)
            {
                TempData["message"] = string.Format("El libro no existe");
                return RedirectToAction("Libros");
            }
            else
            {

                Book deletedProduct = repository.DeleteBook(id);
                if (deletedProduct != null)
                {
                    TempData["message"] = string.Format("{0} borrado correctamente",
                    deletedProduct.Name);
                }
                return RedirectToAction("Libros");
            }
        }

        protected override void Dispose(bool disposing)
        {
            repository.db.Dispose();
            base.Dispose(disposing);
        }
	}
}