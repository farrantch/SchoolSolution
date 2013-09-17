﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("Area")]
    public class Area
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AreaId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<CheckoutAreaTicket> History { get; set; }
    }
}