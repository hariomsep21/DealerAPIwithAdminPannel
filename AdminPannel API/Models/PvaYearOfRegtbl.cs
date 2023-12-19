using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class PvaYearOfRegtbl
{
    public int YearId { get; set; }

    public int YearCode { get; set; }

    public virtual ICollection<PvAggregatorstbl> PvAggregatorstbls { get; set; } = new List<PvAggregatorstbl>();
}
