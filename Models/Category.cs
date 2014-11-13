using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CeniraBiblioteca.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Debes ingresar el nombre de la categoria")]
        public string CategoryName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}