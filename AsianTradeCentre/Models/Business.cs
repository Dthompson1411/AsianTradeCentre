using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTradeCentre.Models
{
    public class Business
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Range(0, 9)]
        public int PostalCode { get; set; }

        [Range(0, 9)]
        public int PhoneNum { get; set; }



        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //validation of this needs to take place on the form submission portion??
        //[System.ComponentModel.DataAnnotations.RegularExpression("\\www\\.\\s+\\.com", ErrorMessage = "Invalid Web address Format")]
        public string WebAddress { get; set; }

    }
}
