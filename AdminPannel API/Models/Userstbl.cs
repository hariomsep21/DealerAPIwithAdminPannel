using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class Userstbl
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public int? Sid { get; set; }

    public int? Otp { get; set; }

    public DateTime Otpexpiry { get; set; }

    public string Phone { get; set; } = null!;

    public string? RefreshToken { get; set; }

    public DateTime? TokenCreated { get; set; }

    public DateTime? TokenExpires { get; set; }

    public virtual ICollection<AccountDetailstbl> AccountDetailstbls { get; set; } = new List<AccountDetailstbl>();

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Notificationstbl> Notificationstbls { get; set; } = new List<Notificationstbl>();

    public virtual ICollection<ProfileInformationtbl> ProfileInformationtbls { get; set; } = new List<ProfileInformationtbl>();

    public virtual ICollection<PvAggregatorstbl> PvAggregatorstbls { get; set; } = new List<PvAggregatorstbl>();

    public virtual ICollection<PvNewCarDealerstbl> PvNewCarDealerstbls { get; set; } = new List<PvNewCarDealerstbl>();

    public virtual ICollection<PvOpenMarketstbl> PvOpenMarketstbls { get; set; } = new List<PvOpenMarketstbl>();

    public virtual ICollection<RegisterAddress> RegisterAddresses { get; set; } = new List<RegisterAddress>();

    public virtual Statetbl? SidNavigation { get; set; }
}
