﻿namespace AdminPannel_API.Models.DTO
{
    public class ProcurementStatusDto:ProcDetailDto
    {

 
        public int Status { get; set; }
        public string Purchased_Amount { get; set; }
    }
}
