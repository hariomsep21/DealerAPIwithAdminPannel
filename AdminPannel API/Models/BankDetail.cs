using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class BankDetail
{
    public int RepaymentDetailId { get; set; }

    public string Name { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string Ifsccode { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
