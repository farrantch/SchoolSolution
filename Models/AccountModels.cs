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

        public IEnumerable<Ethnicity> Ethnicity { get; set; }

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

        public decimal Balance { get; set; }
        public string SSN { get; set; }
        public string Grade { get; set; }
        public bool Verified { get; set; }

        [Display(Name = "Disable Library Checkout")]
        public bool DisableLibraryCheckout { get; set; }

        [Display(Name = "Disable Area Checkout")]
        public bool DisableAreaCheckout { get; set; }

        [Display(Name = "Disable Equipment Checkout")]
        public bool DisableEquipmentCheckout { get; set; }
        public bool Graduate { get; set; }

        [Display(Name = "Subsidized Lunch")]
        public bool SubsidizedLunch { get; set; }

        [Display(Name = "Bus Rider")]
        public bool BusRider { get; set; }

        [Display(Name = "Exchange Student")]
        public bool ExchangeStudent { get; set; }


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

        public string GetFirstLastName{
            get{
                return FirstName + " " + LastName;
            }
        }

        public int Age{
            get{
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public double GPA{
            get{
                //Calculate GPA
                return 0;
            }
        }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate
        {
            get
            {
                return Membership.GetUser(UserName, false).CreationDate;
            }
        }

        [Display(Name = "Approved")]
        public bool IsApproved
        {
            get
            {
                return Membership.GetUser(UserName, false).IsApproved;
            }
        }

        [Display(Name = "Locked Out")]
        public bool IsLockedOut
        {
            get
            {
                return Membership.GetUser(UserName, false).IsLockedOut;
            }
        }

        [Display(Name = "Online")]
        public bool IsOnline
        {
            get
            {
                return Membership.GetUser(UserName, false).IsOnline;
            }
        }

        [Display(Name = "Last Activity Date")]
        public DateTime LastActivityDate
        {
            get
            {
                return Membership.GetUser(UserName, false).LastActivityDate;
            }
        }

        [Display(Name = "Last Lockout Date")]
        public DateTime LastLockoutDate
        {
            get
            {
                return Membership.GetUser(UserName, false).LastLockoutDate;
            }
        }

        [Display(Name = "Last Login Date")]
        public DateTime LastLoginDate
        {
            get
            {
                return Membership.GetUser(UserName, false).LastLoginDate;
            }
        }

        [Display(Name = "Last Password Changed Date")]
        public DateTime LastPasswordChangedDate
        {
            get
            {
                return Membership.GetUser(UserName, false).LastPasswordChangedDate;
            }
        }

        [Display(Name = "Password Question")]
        public string PasswordQuestion
        {
            get
            {
                return Membership.GetUser(UserName, false).PasswordQuestion;
            }
        }
    }
}
