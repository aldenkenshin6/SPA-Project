using System;
using System.Collections.Generic;

namespace SPA1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? ContactNumber { get; set; }

    public string? Availability { get; set; }

    public decimal? CommisionRate { get; set; }

    public string? Email { get; set; }

    public string? Role { get; set; }

    public DateOnly? DateCreated { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Accountings> Accountings { get; set; } = new List<Accountings>();


}
