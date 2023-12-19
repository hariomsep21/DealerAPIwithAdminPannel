using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class ProcurementFilter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProcDetail> ProcDetails { get; set; } = new List<ProcDetail>();
}
