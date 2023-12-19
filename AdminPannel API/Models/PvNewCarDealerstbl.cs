using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class PvNewCarDealerstbl
{
    public int Id { get; set; }

    public string? PurchaseAmount { get; set; }

    public string? VehicleNumber { get; set; }

    public string? OdometerPicture { get; set; }

    public string? VehiclePicFromFront { get; set; }

    public string? VehiclePicFromBack { get; set; }

    public string? Invoice { get; set; }

    public string? PictOfOrginalRc { get; set; }

    public int UserInfoId { get; set; }

    public virtual Userstbl UserInfo { get; set; } = null!;
}
