using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class StockAuditPurposestbl
{
    public int Id { get; set; }

    public string PurposeName { get; set; } = null!;

    public virtual ICollection<OrderStockAuditstbl> OrderStockAuditstbls { get; set; } = new List<OrderStockAuditstbl>();
}
