using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("CheckoutLibraryItemTicket")]
    public class CheckoutLibraryItemTicket
    {
        [Key]
        public int CheckoutLibraryItemTicketId { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime Due { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual LibraryItem LibraryItem { get; set; }
    }
}