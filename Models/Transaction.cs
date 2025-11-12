using System;
using System.Collections.Generic;

namespace SPA1.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? AppointmentId { get; set; }

    public int? ProductId { get; set; }

    public string? PaymentMethod { get; set; }

    public int? Quantity { get; set; }

    public string? Status { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? AmountChange { get; set; }

    public virtual Appointment? Appointment { get; set; }

    public virtual ICollection<Accountings> Accountings { get; set; } = new List<Accountings>();

    public virtual Product? Product { get; set; }
}
