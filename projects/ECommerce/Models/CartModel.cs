using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerce.Models
{
    public class CartModel
    {
        [Key]
        public int CartId { get;set; }
        [Required]
        // [ForeignKey("User")]
        public string UserId { get;set; }

        public UserModel User { get; set; }
        public decimal TotalAmount { get;set; }
        public ICollection<CartItemModel>CartItems { get; set; }
    }
}