using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class ListPost
    {
        public int PostId { get; set; }
        [Display(Name = "Post Title")]
        public string Title { get; set; }
    }
}
