using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class CreatePost
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least three characters to create the title of your post.")]
        [MaxLength(100, ErrorMessage = "Your post title is too long.")]
        public string Title { get; set; }
        [MaxLength(8000, ErrorMessage = "Your post is too long.")]
        public string Text { get; set; }
    }
}
