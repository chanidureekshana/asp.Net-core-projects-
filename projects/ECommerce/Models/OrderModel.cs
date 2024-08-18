using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ECommerce.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get;set; }
        public string OrderDetails { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public UserModel User { get; set; }
        public DateTime OrderDate { get;set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get;set; }
        public ICollection<OrderItemModel>OrderItems { get;set; }
        // public PaymentModel Payment { get; set; }
    }
}
// all good