using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class Registration
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter Valid Name")]
        public string RegistrationName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}