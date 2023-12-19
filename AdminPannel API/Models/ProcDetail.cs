using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class ProcDetail
{
    public int Id { get; set; }

    public DateTime? ClosedOn { get; set; }

    public int Status { get; set; }

    public int FilterId { get; set; }

    public string PurchasedAmount { get; set; } = null!;

    public int PayId { get; set; }

    public virtual ProcurementFilter Filter { get; set; } = null!;

    public virtual Payment Pay { get; set; } = null!;
}
