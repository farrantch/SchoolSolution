using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolSolution.Models;

namespace SchoolSolution.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Course> Prequisites { get; set; }

        public virtual IEnumerable<CourseTicket> CourseHistory { get; set; }
    }
}