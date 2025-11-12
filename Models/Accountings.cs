using System;
using System.Collections.Generic;

namespace SPA1.Models
{
    public partial class Accountings
    {
        public int AccountingId { get; set; }

        public int? TransactionId { get; set; }

        public int? UserId { get; set; }

        public DateTime? EntryDate { get; set; }

        public string? Description { get; set; }

        public string? AccountType { get; set; }

        public string? AccountCategory { get; set; }

        public decimal? DebitAmount { get; set; }

        public decimal? CreditAmount { get; set; }

        public decimal? Balance { get; set; }

        public virtual Transaction? Transaction { get; set; }

        public virtual User? User { get; set; }


    }
}
