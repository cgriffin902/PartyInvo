using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage= "Please Enter a Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter a Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Select one")]
        public bool? WillAttend { get; set; }
    }
}