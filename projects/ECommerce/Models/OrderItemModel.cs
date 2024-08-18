using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class OrderItemModel
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get ;set ; }

        [Required]
        [ForeignKey("Product")]
        public OrderModel Order { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } 
    }
}