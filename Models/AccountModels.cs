using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Web.Mvc;

namespace SchoolSolution.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        [Display(Name = "Apartment Number")]
        public int? ApartmentNumber { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "State/Providence")]
        public string StateProvince { get; set; }

        //EVERYTHING ABOVE THIS LINE ON REGISTRATION FORM

        [Display(Name = "Last Activity On")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm:ss tt}")]
        public DateTime LastActivityOn { get; set; }

        [Display(Name = "Account Created On")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm:ss tt}")]
        public DateTime AccountCreatedOn { get; set; }

        [Display(Name = "Password Changed On")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm:ss tt}")]
        public DateTime PasswordChangedOn { get; set; }

        public decimal Balance { get; set; }

        public bool Disabled { get; set; }
        public bool Verified { get; set; }
        public bool DisableLibraryCheckout { get; set; }
        public bool DisableAreaCheckout { get; set; }
        public bool DisableEquipmentCheckout { get; set; }
        public bool Graduate { get; set; }
        public bool SubsidizedLunch { get; set; }
        public bool BusRider { get; set; }
        public string SSN { get; set; }
        public string Grade { get; set; }

        //public ICollection<Immunization> Immunizations { get; set; }
        //public ICollection<PhoneNumber> PhoneNumbers { get; set; }
        //public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<CheckoutLibraryItemTicket> LibraryItems { get; set; }
        public virtual ICollection<CheckoutEquipmentTicket> EquipmentItems { get; set; }
        public virtual ICollection<CheckoutAreaTicket> AreasReserved { get; set; }
        public virtual ICollection<Guardian> Guardians { get; set; }
        public virtual ICollection<UserProfile> Guardianship { get; set; }

        //List of awards
        //List of curriculum

        public byte[] Photo { get; set; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public double GPA
        {
            get
            {
                //Calculate GPA
                return 0;
            }
        }
    }
}
