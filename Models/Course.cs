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

        public virtual UserProfile Instructor { get; set; }

        public virtual IEnumerable<UserProfile> Assistants { get; set; }

        public virtual IEnumerable<UserProfile> Students { get; set; }

        public virtual IEnumerable<Course> Prerequisites { get; set; }

        [Display(Name = "Starting Time")]
        public DateTime TimeStart { get; set; }

        [Display(Name = "Length of Class")]
        public TimeSpan TimeLength { get; set; }

        [Display(Name = "Starting Date")]
        public DateTime DateStart { get; set; }

        [Display(Name = "Ending Date")]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Final Exam Date and Time")]
        public DateTime FinalExamDateTime { get; set; }

        [Display(Name = "Final Exam Length")]
        public TimeSpan FinalExamLength { get; set; }
    }
}