using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("Term")]
    public class Term
    {
        [Key]
        public int TermId { get; set; }

        //Ex: Fall Semester 2013, Winter Intersession 2013-2014, 1st Quarter 2013-2014, Summer May 21st - June 30th
        public string Name { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }

        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
    }
}