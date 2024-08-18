using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaApp.Models
{
    public class FriendshipModel
    {
        [Key]
        public int FriendshipId { get; set; }
        [Required]
        [ForeignKey("UserModel")]
        public int UserId { get ;set ;}
        [Required]
        [ForeignKey("UserModel")]
        public int FriendId { get; set; }
        public string Status { get; set; }
        public ICollection<UserModel>User { get; set; }
        public ICollection<UserModel> Friend { get; set; }
        
    }
}
// Define properties: FriendshipId, UserId, FriendId, Status