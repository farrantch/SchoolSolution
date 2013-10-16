using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSolution.Models
{
    public class Ethnicity
    {
        public string EthnicityId { get; set; }

        public static List<Ethnicity> GetEthnicities()
        {
            return new List<Ethnicity>
            {
                new Ethnicity { EthnicityId = "African American"},
                new Ethnicity { EthnicityId = "Caucasion"},
                new Ethnicity { EthnicityId = "Chinese"},
                new Ethnicity { EthnicityId = "French"},
                new Ethnicity { EthnicityId = "Hispanic"},
                new Ethnicity { EthnicityId = "Italian"},
                new Ethnicity { EthnicityId = "Japanese"},
                new Ethnicity { EthnicityId = "Korean"},
                new Ethnicity { EthnicityId = "Native American"},
                new Ethnicity { EthnicityId = "Puerto Rican"},
                new Ethnicity { EthnicityId = "Vietnamese"}
            };
        }
    }
}