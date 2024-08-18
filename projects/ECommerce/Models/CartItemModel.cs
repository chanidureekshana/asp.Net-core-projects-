using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class CartItemModel
    {
        [Key]
        public int CartItemId { get;set; }

        [Required]
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public CartModel Cart { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get;set; }
        public ProductModel Product { get; set; }
        public int Quantity { get;set; }
        public decimal Price  {get;set ;}

    }
}