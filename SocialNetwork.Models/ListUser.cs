using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class ListUser
    {
        public int UserId { get; set; }
        [Display(Name = "User's Name")]
        public string Name { get; set; }
    }
}
