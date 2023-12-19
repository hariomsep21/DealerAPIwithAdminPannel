using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class RegisterAddress
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public int IdU { get; set; }

    public string AddressType { get; set; } = null!;

    public virtual Userstbl IdUNavigation { get; set; } = null!;
}
