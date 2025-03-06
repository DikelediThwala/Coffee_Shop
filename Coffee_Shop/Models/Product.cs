using System;
using System.Collections.Generic;

namespace Coffee_Shop.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public byte[]? Image { get; set; }

    public int OwnerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Owner Owner { get; set; } = null!;
}
