using CeniraBiblioteca.Models.DAL;
using CeniraBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeniraBiblioteca.Models.Repositories
{
    public class BookRepository
    {
        public CeniraContext db = new CeniraContext();

        public void SaveBook(Book book)
        {
            if (book.BookID == 0)
            {
                db.Books.Add(book);
            }
            else
            {
                Book dbEntry =
                db.Books.Find(book.BookID);
                if (dbEntry != null)
                {
                    dbEntry.Name = book.Name;
                    dbEntry.Description = book.Description;
                    dbEntry.Author = book.Author;
                    dbEntry.DatePublished = book.DatePublished;
                    dbEntry.Edition = book.Edition;
                    dbEntry.Pages = book.Pages;
                    dbEntry.ImageURL = book.ImageURL;
                    dbEntry.Publisher = book.Publisher;
                    dbEntry.CategoryID = book.CategoryID;
                    dbEntry.Status = book.Status;
                }
            }

            db.SaveChanges();
        }

        public Book DeleteBook(int bookID)
        {
            Book dbEntry = db.Books.Find(bookID);
            if (dbEntry != null)
            {
                db.Books.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}