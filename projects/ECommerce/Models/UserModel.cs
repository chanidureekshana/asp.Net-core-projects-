using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace ECommerce.Models
{
    public class UserModel:IdentityUser
    {
        public UserModel()
        {
            var Carts  = new HashSet<CartModel>();
        //     var Orders = new HashSet<OrderModel>();
        }
        [Key]
        public int  UserId { get; set; }
        public string UserName { get ; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        // public ICollection<OrderModel>Orders { get; set; }
        public ICollection<CartModel> Cart { get; set; }
         
    }
}