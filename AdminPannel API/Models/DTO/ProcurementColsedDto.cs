﻿using System.Numerics;

namespace AdminPannel_API.Models.DTO
{
    public class ProcurementColsedDto:ProcDetailDto
    {
        public decimal? Amount_paid { get; set; }
        public DateTime? ColsedOn { get; set; }
    }
}
