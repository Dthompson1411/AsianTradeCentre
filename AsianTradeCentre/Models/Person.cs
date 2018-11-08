using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTradeCentre.Models
{
    public class Person
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }
               
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "You are required to enter you first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You are required to enter you last name")]
        public string LastName { get; set; }

        public bool isUser { get; set; }

        public bool isManager { get; set; }

        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        public string EmailAddress { get; set; }

        [Required (ErrorMessage = "Address is Required")]
        [Display(Name = "Enter Address")]
        public string Address { get; set; }





    }
}
