using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SocialMediaApp.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [ForeignKey("PostModel")]
        public int PostId { get ;set; }
        [Required]
        [ForeignKey("UserModel")]
        public int UserId { get; set; }
        [Required]
        public string Content { get;set ;}
        public ICollection<PostModel>Post { get; set; }
        public ICollection<UserModel> User { get; set; }
    }
}
// Define properties: CommentId, PostId, UserId, Content, CreatedDate