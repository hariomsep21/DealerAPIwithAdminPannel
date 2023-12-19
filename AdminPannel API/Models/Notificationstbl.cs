using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class Notificationstbl
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Discription { get; set; } = null!;

    public DateTime MessageTime { get; set; }

    public int UserInfoId { get; set; }

    public virtual Userstbl UserInfo { get; set; } = null!;
}
