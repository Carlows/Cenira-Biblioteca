using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CeniraBiblioteca.Models
{
    public class Pedidos
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debes ingresar tu cedula")]
        public int Cedula { get; set; }
        public int BookID { get; set; }
        public virtual Book book { get; set; }
    }
}