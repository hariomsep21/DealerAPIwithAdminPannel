using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public string Variant { get; set; } = null!;

    public string? Image { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<StockAudit> StockAudits { get; set; } = new List<StockAudit>();

    public virtual Userstbl User { get; set; } = null!;

    public virtual ICollection<VehicleRecord> VehicleRecords { get; set; } = new List<VehicleRecord>();
}
