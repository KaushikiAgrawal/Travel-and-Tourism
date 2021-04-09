using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace project1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name..")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Email..")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please Enter Your Contact Number..")]
        [Display(Name="Phone Number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter a valid phone number")]
        public string PhoneNumber{  get; set; }


        [Required(ErrorMessage = "Please Enter Password..")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please Confirm Your Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }

    
    }
}
