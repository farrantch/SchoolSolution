using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolSolution.Models
{
    public class PhoneNumber
    {
        [Phone]
        public string Number;
        public string Extension;
        public string Description;
        public bool Primary;
        
        //Needs to be a selection. Ie: Mobile, Home, Work, etc..
        //public string Type;
    }
}