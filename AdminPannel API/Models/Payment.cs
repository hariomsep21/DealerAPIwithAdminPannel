using System;
using System.Collections.Generic;

namespace AdminPannel_API.Models;

public partial class Payment
{
    public int Id { get; set; }

    public decimal AmountDue { get; set; }

    public int CarId { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime StartDate { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? ProcessingCharges { get; set; }

    public decimal? FacilityAvailed { get; set; }

    public decimal? InvoiceCharges { get; set; }

    public int BankId { get; set; }


    public int? PaymentStatus { get; set; }

    public string PaymentProofImg { get; set; } = null!;

    public virtual BankDetail Bank { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<ProcDetail> ProcDetails { get; set; } = new List<ProcDetail>();
}
