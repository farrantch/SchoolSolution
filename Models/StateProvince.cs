using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSolution.Models
{
    public class StateProvince
    {
        public string StateId { get; set; }
        public string CountryCode { get; set; }

        // We can fetch data from any data source here.
        public static List<StateProvince> GetStates()
        {
            return new List<StateProvince>
            {
                //United States
                new StateProvince { CountryCode = "US", StateId = "Alabama" },
                new StateProvince { CountryCode = "US", StateId = "Alaska" },
                new StateProvince { CountryCode = "US", StateId = "Arizona" },
                new StateProvince { CountryCode = "US", StateId = "Arkansas" },
                new StateProvince { CountryCode = "US", StateId = "California" },
                new StateProvince { CountryCode = "US", StateId = "Colorado" },
                new StateProvince { CountryCode = "US", StateId = "Connecticut" },
                new StateProvince { CountryCode = "US", StateId = "Delaware" },
                new StateProvince { CountryCode = "US", StateId = "Florida" },
                new StateProvince { CountryCode = "US", StateId = "Georgia" },
                new StateProvince { CountryCode = "US", StateId = "Hawaii" },
                new StateProvince { CountryCode = "US", StateId = "Idaho" },
                new StateProvince { CountryCode = "US", StateId = "Illinois" },
                new StateProvince { CountryCode = "US", StateId = "Indiana" },
                new StateProvince { CountryCode = "US", StateId = "Iowa" },
                new StateProvince { CountryCode = "US", StateId = "Kansas" },
                new StateProvince { CountryCode = "US", StateId = "Kentucky" },
                new StateProvince { CountryCode = "US", StateId = "Louisianna" },
                new StateProvince { CountryCode = "US", StateId = "Maine" },
                new StateProvince { CountryCode = "US", StateId = "Maryland" },
                new StateProvince { CountryCode = "US", StateId = "Massachusetts" },
                new StateProvince { CountryCode = "US", StateId = "Michigan" },
                new StateProvince { CountryCode = "US", StateId = "Minnesota" },
                new StateProvince { CountryCode = "US", StateId = "Mississippi" },
                new StateProvince { CountryCode = "US", StateId = "Missouri" },
                new StateProvince { CountryCode = "US", StateId = "Montana" },
                new StateProvince { CountryCode = "US", StateId = "Nebraska" },
                new StateProvince { CountryCode = "US", StateId = "Nevada" },
                new StateProvince { CountryCode = "US", StateId = "New Hampshire" },
                new StateProvince { CountryCode = "US", StateId = "New Jersey" },
                new StateProvince { CountryCode = "US", StateId = "New Mexico" },
                new StateProvince { CountryCode = "US", StateId = "New York" },
                new StateProvince { CountryCode = "US", StateId = "North Carolina" },
                new StateProvince { CountryCode = "US", StateId = "North Dakota" },
                new StateProvince { CountryCode = "US", StateId = "Ohio" },
                new StateProvince { CountryCode = "US", StateId = "Oklahoma" },
                new StateProvince { CountryCode = "US", StateId = "Oregon" },
                new StateProvince { CountryCode = "US", StateId = "Pennsylvania" },
                new StateProvince { CountryCode = "US", StateId = "Rhode Island" },
                new StateProvince { CountryCode = "US", StateId = "South Carolina" },
                new StateProvince { CountryCode = "US", StateId = "South Dakota" },
                new StateProvince { CountryCode = "US", StateId = "Tennessee" },
                new StateProvince { CountryCode = "US", StateId = "Texas" },
                new StateProvince { CountryCode = "US", StateId = "Utah" },
                new StateProvince { CountryCode = "US", StateId = "Vermont" },
                new StateProvince { CountryCode = "US", StateId = "Virginia" },
                new StateProvince { CountryCode = "US", StateId = "Washington" },
                new StateProvince { CountryCode = "US", StateId = "West Virginia" },
                new StateProvince { CountryCode = "US", StateId = "Wisconson" },
                new StateProvince { CountryCode = "US", StateId = "Wyoming" },
                
                //United Kingdom
                new StateProvince { CountryCode = "UK", StateId = "Scotland" },
                new StateProvince { CountryCode = "UK", StateId = "Britian" }
            };
        }
    }
}