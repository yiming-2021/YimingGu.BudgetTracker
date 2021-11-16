using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YimingGu.BudgetTracker.ApplicationCore.Entities
{
    [Table("Expenditure")]
    public class Expenditure
    {
        public int Id { get; set; }
        
        public int? UserId { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        
        [MaxLength(100)]
        public string Description { get; set; }
        
        public DateTime? ExpDate { get; set; }
        
        [MaxLength(500)]
        public string Remarks { get; set; }


        //NP
        public User User { get; set; }
    }
}