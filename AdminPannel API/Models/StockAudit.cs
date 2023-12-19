using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class StockAudit
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public DateTime AuditDate { get; set; }

    public int? Status { get; set; }

    public string Image1 { get; set; } = null!;

    public string Image2 { get; set; } = null!;

    public string Image3 { get; set; } = null!;

    public bool? Varified { get; set; }

    public virtual Car Car { get; set; } = null!;
}
