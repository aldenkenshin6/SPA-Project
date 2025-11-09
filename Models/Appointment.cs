using System;
using System.Collections.Generic;

namespace SPA1.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? UserId { get; set; }

    public int? CustomerId { get; set; }

    public int? ServiceId { get; set; }

    public DateTime? StartingTime { get; set; }

    public string? Notes { get; set; }

    public string? Status { get; set; }

    public DateOnly? AppointmentDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Service? Service { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User? User { get; set; }
}
