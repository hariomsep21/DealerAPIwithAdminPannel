using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class PvaModeltbl
{
    public int ModelId { get; set; }

    public string ModelName { get; set; } = null!;

    public int ModelCode { get; set; }

    public virtual ICollection<PvAggregatorstbl> PvAggregatorstbls { get; set; } = new List<PvAggregatorstbl>();
}
