namespace CeniraBiblioteca.Migrations
{
    using CeniraBiblioteca.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CeniraBiblioteca.Models.DAL.CeniraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CeniraBiblioteca.Models.DAL.CeniraContext context)
        {
            /*
            context.Categories.AddOrUpdate(
                new Category { CategoryName = "Programacion" },
                new Category { CategoryName = "Literatura" },
                new Category { CategoryName = "Matematicas" },
                new Category { CategoryName = "Data" }
                );

            context.SaveChanges();

            context.Books.AddOrUpdate(
                new Book { Name = "Libro 1", Author = "Autor 1", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Matematicas").CategoryID },
                new Book { Name = "Libro 2", Author = "Autor 2", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Matematicas").CategoryID },
                new Book { Name = "Libro 3", Author = "Autor 3", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Matematicas").CategoryID },
                new Book { Name = "Libro 4", Author = "Autor 4", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Matematicas").CategoryID },
                new Book { Name = "Libro 5", Author = "Autor 5", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Programacion").CategoryID },
                new Book { Name = "Libro 6", Author = "Autor 6", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Programacion").CategoryID },
                new Book { Name = "Libro 7", Author = "Autor 7", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Programacion").CategoryID },
                new Book { Name = "Libro 8", Author = "Autor 8", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Programacion").CategoryID },
                new Book { Name = "Libro 9", Author = "Autor 9", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Literatura").CategoryID },
                new Book { Name = "Libro 10", Author = "Autor 10", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Literatura").CategoryID },
                new Book { Name = "Libro 11", Author = "Autor 11", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Literatura").CategoryID },
                new Book { Name = "Libro 12", Author = "Autor 12", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Literatura").CategoryID },
                new Book { Name = "Libro 13", Author = "Autor 13", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Data").CategoryID },
                new Book { Name = "Libro 14", Author = "Autor 14", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Data").CategoryID },
                new Book { Name = "Libro 15", Author = "Autor 15", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Data").CategoryID },
                new Book { Name = "Libro 16", Author = "Autor 16", DatePublished = DateTime.Parse("2000-12-12"), Edition = 1, Description = "A Book", Pages = 500, Publisher = "Carlos", ImageURL = "http://virtual.urbe.edu/librotexto/621_FIS_1/portada.jpg", CategoryID = context.Categories.ToList().Single(c => c.CategoryName == "Data").CategoryID }
            );

            context.SaveChanges();
             * */
        }
    }
}
