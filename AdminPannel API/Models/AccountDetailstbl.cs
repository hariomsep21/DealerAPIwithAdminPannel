using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class AccountDetailstbl
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string Ifsccode { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public int UserInfoId { get; set; }

    public virtual Userstbl UserInfo { get; set; } = null!;
}
