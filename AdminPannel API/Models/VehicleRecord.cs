using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class VehicleRecord
{
    public int Id { get; set; }

    public bool Challan { get; set; }

    public bool RcStatus { get; set; }

    public bool Fitness { get; set; }

    public bool OwnerName { get; set; }

    public bool Hypothecation { get; set; }

    public bool Blacklist { get; set; }

    public int Cid { get; set; }

    public virtual Car CidNavigation { get; set; } = null!;
}
