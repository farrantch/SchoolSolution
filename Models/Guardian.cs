using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSolution.Models
{
    [Table("Guardian")]
    public class Guardian
    {
        [Key]
        public int GuardianId { get; set; }
        public bool PrimaryContact { get; set; }
        public string RelationshipIdSelector { get; set; }
    }

    public class Relationship
    {
        public string RelationshipId { get; set; }

        public static List<Relationship> GetRelationshipList()
        {
            return new List<Relationship>
            {
                new Relationship { RelationshipId = "Mother"},
                new Relationship { RelationshipId = "Father"},
                new Relationship { RelationshipId = "Grandmother"},
                new Relationship { RelationshipId = "Grandfather"},
                new Relationship { RelationshipId = "Aunt"},
                new Relationship { RelationshipId = "Uncle"},
                new Relationship { RelationshipId = "Brother"},
                new Relationship { RelationshipId = "Sister"},
                new Relationship { RelationshipId = "Legal Guardian"},
                new Relationship { RelationshipId = "Financial Support"}
            };
        }
    }
}