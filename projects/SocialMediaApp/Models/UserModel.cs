using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaApp.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]

        public string Location { get; set; }
        [Required]
        public string Bio { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public ICollection<PostModel> Posts { get; set; } = new List<PostModel>();
        public ICollection<CommentModel> Comments { get; set; } = new List<CommentModel>();
        public ICollection<FriendshipModel> Friendships { get; set; } = new List<FriendshipModel>();
        public ICollection<FriendshipModel> Friends { get; set; } = new List<FriendshipModel>();
    }
}