using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialMediaApp.Models
{
    public class PostModel
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        [ForeignKey("UserModel")]
        public int UserId { get; set; }
        [Required]
        public string Content { get; set; }
        public ICollection<UserModel>User { get; set; }
        public ICollection<CommentModel> Comments { get; set; } = new List<CommentModel>();
    }
}