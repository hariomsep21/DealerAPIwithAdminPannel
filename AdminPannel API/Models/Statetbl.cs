using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class Statetbl
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public string StateCode { get; set; } = null!;

    public virtual ICollection<Userstbl> Userstbls { get; set; } = new List<Userstbl>();
}
