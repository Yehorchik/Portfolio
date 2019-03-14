using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Portfolio .Models
{
    public class Mail
    {
        [Required]
        [MinLength (5, ErrorMessage="Email is required!")]
        public string Email { get; set;}

        [Required]
        [MinLength (3, ErrorMessage="Name is required!")]
        public string Name { get; set;}

        [Required]
        [MinLength (10, ErrorMessage="Message required ,minimum 10 characters")]
        public string Message { get; set;}

    }
}