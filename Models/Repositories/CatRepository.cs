using CeniraBiblioteca.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeniraBiblioteca.Models.Repositories
{
    public class CatRepository
    {
        public CeniraContext db = new CeniraContext();

        public void SaveCategory(Category cat)
        {
            if (cat.CategoryID == 0)
            {
                db.Categories.Add(cat);
            }
            else
            {
                Category dbEntry =
                db.Categories.Find(cat.CategoryID);
                if (dbEntry != null)
                {
                    dbEntry.CategoryName = cat.CategoryName;
                }
            }

            db.SaveChanges();
        }

        public Category DeleteCategory(int catID)
        {
            Category dbEntry = db.Categories.Find(catID);
            if (dbEntry != null)
            {
                db.Categories.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}