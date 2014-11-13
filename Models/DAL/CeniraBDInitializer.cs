using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CeniraBiblioteca.Models.DAL
{
    public class CeniraBDInitializer : DropCreateDatabaseIfModelChanges<CeniraContext>
    {
        protected override void Seed(CeniraContext context)
        {
            // REMOVER ESTE CODIGO AL IR A PRODUCCION, YA QUE DARA ERRORES EN LA BD
            var categories = new List<Category>
            {
                new Category{ CategoryName = "Matematicas" },
                new Category{ CategoryName = "Programacion" },
                new Category{ CategoryName = "Literatura" }
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book{ Name = "Mathematics for the Nonmathematician", Author = "Morris Kline", Description = "Practical, scientific, philosophical, and artistic problems have caused men to investigate mathematics.", DatePublished = DateTime.Parse("1985-02-01"), Edition = 2, Pages = 100, Publisher = "Amazon", CategoryID = categories.Single(c => c.CategoryName == "Matematicas").CategoryID},
                new Book{ Name = "Great Formulas Explained - Physics, Mathematics, Economics", Author = "Metin Bektas", Description = "Mathematics.", DatePublished = DateTime.Parse("2000-02-01"), Edition = 3, Pages = 530, Publisher = "Amazon", CategoryID = categories.Single(c => c.CategoryName == "Matematicas").CategoryID},
                new Book{ Name = "LINQ In Action", Author = "Matt Warren", Description = "Wanna see linq in action, bitch?", DatePublished = DateTime.Parse("2010-02-01"), Edition = 5, Pages = 1530, Publisher = "APRESS", CategoryID = categories.Single(c => c.CategoryName == "Programacion").CategoryID},
                new Book{ Name = "Pro ASP.NET MVC 5", Author = "Adam Freeman", Description = "Asp.net MVC 5", DatePublished = DateTime.Parse("2013-02-01"), Edition = 4, Pages = 1030, Publisher = "APRESS", CategoryID = categories.Single(c => c.CategoryName == "Programacion").CategoryID},
                new Book{ Name = "The Alchemist", Author = "Paulo Coelho", Description = "My heart is afraid that it will have to suffer,", DatePublished = DateTime.Parse("2006-02-01"), Edition = 1, Pages = 330, Publisher = "Amazon", CategoryID = categories.Single(c => c.CategoryName == "Literatura").CategoryID},
                new Book{ Name = "Warrior of the Light: A Manual", Author = "Paulo Coelho", Description = "Another Paulo Coelho book", DatePublished = DateTime.Parse("2004-02-01"), Edition = 1, Pages = 160, Publisher = "Amazon", CategoryID = categories.Single(c => c.CategoryName == "Literatura").CategoryID}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}