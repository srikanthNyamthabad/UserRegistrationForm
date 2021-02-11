using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationForm.Models
{
    public class User
    {
        [Key]
        public int userId { set; get; }
    

        [Required(ErrorMessage = "Please Enter Name..")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Age..")]
        [Range(18, 100, ErrorMessage = "Can only be between 18 .. 100")]
        public int Age { get; set; }

        
        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhonNumber{get;set;}




    }
}
