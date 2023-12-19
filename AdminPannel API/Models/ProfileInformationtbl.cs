using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class ProfileInformationtbl
{
    public int Id { get; set; }

    public string ContactNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string ShopAddress { get; set; } = null!;

    public string ResidenceAddress { get; set; } = null!;

    public string AlternativeNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string City { get; set; } = null!;

    public int AccountDetails { get; set; }

    public int UserInfoId { get; set; }

    public virtual Userstbl UserInfo { get; set; } = null!;
}
