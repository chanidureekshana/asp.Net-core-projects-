using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class PaymentModel
    {
        [Key]
        public int PaymentId {get; set; }
        // [ForeignKey("Order")]
        public int OrderId { get;set; }
        // public OrderModel Order { get; set; }
        public DateTime PaymentDate { get ;set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; } 
    }
}