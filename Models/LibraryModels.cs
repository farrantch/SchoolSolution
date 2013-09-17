using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolSolution.Validations;


namespace SchoolSolution.Models
{
    [Table("LibraryItem")]
    public abstract class LibraryItem
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LibraryItemID { get; set; }

        [Display(Name = "Date Published")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DatePublished { get; set; }

        public int Barcode { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CheckoutLibraryItemTicket> History { get; set; }

        public bool Available
        {
            get
            {
                return true;
                //return LibraryCheckoutHistory
            }
        }
    }

    public abstract class LibraryItemWithTitle : LibraryItem
    {
        [Required]
        public string Title { get; set; }
    }

    public class Book : LibraryItemWithTitle
    {
        [ISBNValidation]
        public string ISBN { get; set; }

        public DateTime DateAdded { get; set; }

        public string[] Authors { get; set; }

        public string Publisher { get; set; }

        public IEnumerable<string> Category { get; set; }         //Dictionary, Theasaurs, Encyclopedia, Fiction, Non-Fiction, Picture, Cookbook, Diary, Comic, Biography, Autobiography 

        public IEnumerable<string> Style { get; set; } //Sci-Fi, Fantasy, Thriller, Romance
        
        //# of Pages
    }

    public class Video : LibraryItemWithTitle
    {
        //RunTime
        //ParentalRating
        //
    }

    public class Audio : LibraryItemWithTitle
    {
        //Length
        //
    }

    public class Magazine : LibraryItem
    {
        [Required]
        public string MagazineName { get; set; }
    }

    public class Newspaper : LibraryItem
    {
        //Newspaper Name
    }
}