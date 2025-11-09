using System;
using System.Collections.Generic;

namespace SPA1.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public int? ContactNumber { get; set; }

    public string? Address { get; set; }

    public string? EmailAddress { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
