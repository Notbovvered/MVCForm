using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCForm.Models
{
    public class WebUser
    {
        [Required]
        [StringLength(25)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength =3)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Mail Address field!")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address!")]
        public string MailAddress { get; set; }
    }
}
