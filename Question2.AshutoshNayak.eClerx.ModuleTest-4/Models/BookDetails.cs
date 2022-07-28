using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Question2.AshutoshNayak.eClerx.ModuleTest_4.Models
{
    public class BookDetails
    {
    
        public int Id { get; set; }
        //[Required(ErrorMessage = "ISBN Cant be duplicate")]
        //[Display( Name="ISBN Name ")]
        public string ISBN { get; set; }
        //[Required(ErrorMessage = "Book Name cant be Empty")]
        //[Display(Name = "Book Name ")]
        public string BookName { get; set; }
        //[Required(ErrorMessage = "Genre cant be empty")]
        //[Display(Name = "Genre Name ")]
        public string Genre { get; set; }
        //[Required(ErrorMessage = "Author name should be given")]
        //[Display(Name = "Author Name ")]
        public string AuthorName { get; set; }

        //modified coloumns
        public DateTime PublishedDate { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}