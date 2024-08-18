using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementSystem.Models
{
    public class RegistrationModel
    {
        [Key]
        public int RegistrationId { get; set; }
        
        [ForeignKey("EventModel")]
        public int EventId { get; set; }
        public EventModel? Event { get; set; }
        
        [ForeignKey("UserModel")]
        public int UserId { get; set; }
        public UserModel? User { get; set; }
        
    }
}