using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace SchoolSolution.Models
{
    public class Gender
    {
        public string GenderId { get; set; }

        public static List<Gender> GetGenderList()
        {
            return new List<Gender>
            {
                new Gender { GenderId = "Male"},
                new Gender { GenderId = "Female"}
            };
        }
    }
}