using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class OrderStockAuditstbl
{
    public int Id { get; set; }

    public string Location { get; set; } = null!;

    public int StockAuditPurposeId { get; set; }

    public DateTime ChooseDate { get; set; }

    public virtual StockAuditPurposestbl StockAuditPurpose { get; set; } = null!;
}
