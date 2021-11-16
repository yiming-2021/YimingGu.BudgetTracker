using System;
using System.Collections.Generic;

namespace YimingGu.BudgetTracker.ApplicationCore.Models
{
    public class UserDetailsResponseModel
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Fullname { get; set; }
        
        public DateTime? JoinedOn { get; set; }
        
        
        public List<IncomeResponseModel> Incomes { get; set; }
        public List<ExpResponseModel> Expenditures { get; set; }
    }
}