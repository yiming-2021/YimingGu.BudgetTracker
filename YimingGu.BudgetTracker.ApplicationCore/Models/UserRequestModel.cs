using System;
using System.ComponentModel.DataAnnotations;

namespace YimingGu.BudgetTracker.ApplicationCore.Models
{
    public class UserRequestModel
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }
        
        public DateTime? JoinedOn { get; set; }
    }
}