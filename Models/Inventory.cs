using System;
using System.Collections.Generic;

namespace SPA1.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? ProductId { get; set; }

    public string? ChangeType { get; set; }

    public int? QuantityChange { get; set; }

    public int? ReordedLevel { get; set; }

    public int? ReferenceId { get; set; }

    public virtual Product? Product { get; set; }
}
