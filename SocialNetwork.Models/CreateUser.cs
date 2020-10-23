using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class CreateUser
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name minimum length = 3 characters")]
        [MaxLength(25, ErrorMessage = "Name max length = 25 characters")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
