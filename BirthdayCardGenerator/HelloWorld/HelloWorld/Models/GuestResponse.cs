using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace HelloWorld.Models
{

    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter whose birthday")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }
    
    }
}
