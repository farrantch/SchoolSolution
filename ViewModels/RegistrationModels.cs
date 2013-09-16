using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSolution.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace SchoolSolution.ViewModels
{
    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {

        [Required]
        [Display(Name = "User Name")]
        [MaxLength(21, ErrorMessage = "User name exceeds maximum length")]
        [MinLength(5, ErrorMessage = "User name is too short.")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(21, ErrorMessage = "First name exceeds maximum length")]
        [MinLength(2, ErrorMessage = "First name is too short.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        [MaxLength(21, ErrorMessage = "Middle name exceeds maximum length")]
        [MinLength(2, ErrorMessage = "Middle name is too short.")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(25, ErrorMessage = "Last name exceeds maximum length")]
        [MinLength(2, ErrorMessage = "Last name is too short.")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        //[Required]
        //public IEnumerable<SelectListItem> Gender {get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[Display(Name = "Birth Date")]
        //public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4)]
        public string Address { get; set; }

        [Display(Name = "Apartment Number")]
        [Range(0, 9999)]
        public int? ApartmentNumber { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [Range(1001, 99999)]
        public string ZipCode { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage="Please select a country.")]
        public string Country { get; set; }

        [Display(Name = "State/Province")]
        //[Required(ErrorMessage="Please select a state/province.")]
        public string StateProvince { get; set; }
    }

    public class RegisterStudentModel
    {
        [Required]
        [RegularExpression(@"^(\d{3}-?\d{2}-?\d{4}|XXX-XX-XXXX)$")]
        private string SSN { get; set; }

        public bool SubsidizedLunch { get; set; }

        //Add Guardians
    }

    public class RegisterFacultyModel
    {

    }

    public class RegisterGuardianModel
    {

    }
}