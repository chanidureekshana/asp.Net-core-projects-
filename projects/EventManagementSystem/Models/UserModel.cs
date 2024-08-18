using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? HashPassword { get; set; }
        public ICollection<RegistrationModel>?Registrations { get;set; }
        public ICollection<TicketModel>? Tickets { get; set; }

    }
}