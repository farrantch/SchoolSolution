using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("CheckoutLibraryTicket")]
    public class CheckoutLibraryTicket
    {
        [Key]
        public int CheckoutLibraryTicketId { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime CheckedIn { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual LibraryItem Item { get; set; }
    }
}