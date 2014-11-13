using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CeniraBiblioteca.Models
{
    public class Book
    {
        public Book()
        {
            this.Status = BookStatus.Available;
        }

        [HiddenInput(DisplayValue = false)]
        public int BookID { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debes ingresar el nombre del libro")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Debes ingresar la descripcion")]
        public string Description { get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Debes ingresar el autor")]
        public string Author { get; set; }
        [Display(Name = "Editorial")]
        [Required(ErrorMessage = "Debes ingresar el editorial")]
        public string Publisher { get; set; }
        [Display(Name = "Paginas")]
        [Required(ErrorMessage = "Debes ingresar el numero de paginas")]
        public int Pages { get; set; }
        [Display(Name = "Fecha de publicacion")]
        [Required(ErrorMessage = "Debes ingresar la fecha de publicacion")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime DatePublished { get; set; }
        [Display(Name = "Edicion")]
        [Required(ErrorMessage = "Debes ingresar la edicion")]
        public int Edition { get; set; }
        [Display(Name = "URL para la imagen")]
        [Required(ErrorMessage = "Debes ingresar un link hacia la imagen del libro")]
        public string ImageURL { get; set; }

        public BookStatus Status { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }

    public enum BookStatus
    {
        Available,
        Unavailable
    }
}