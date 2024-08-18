using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class EventModel
    {
        [Key]
        public int EventId { get; set; }
        
        [Required]
        public string? Title { get; set; }
        
        [Required]
        public string? Description { get; set; }
        
        [Required]
        public string? Location { get; set; }
        
        [Required]
        public int Capacity { get; set; }
        public ICollection<RegistrationModel>?Registrations { get;set; }
        public ICollection<TicketModel>?Tickets { get; set; }
        
    }
}