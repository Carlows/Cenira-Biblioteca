using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CeniraBiblioteca.Models
{
    public class BookViewModel
    {
        public Book book { get; set; }
        public List<string> categories { get; set; }
        public string category { get; set; }
    }
}