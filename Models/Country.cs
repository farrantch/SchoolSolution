using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSolution.Models
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }

        // We can fetch data from any data source here.
        public static List<Country> GetCountryList()
        {
            return new List<Country>
            {
                new Country { CountryId = "IN", Name = "India" },
                new Country { CountryId = "US", Name = "United States" },
                new Country { CountryId = "UK", Name = "United Kingdom" }
            };
        }
    }
}