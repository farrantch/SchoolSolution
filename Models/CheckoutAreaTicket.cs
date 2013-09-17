using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("CheckoutAreaTicket")]
    public class CheckoutAreaTicket
    {
        [Key]
        public int CheckoutAreaTicketId { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime Due { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual Area Area { get; set; }
    }
}