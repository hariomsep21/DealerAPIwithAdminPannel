﻿using System.ComponentModel.DataAnnotations;

namespace AdminPannel_API.Models.DTO
{
    public class ProcurementFilterDto
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Adjust the max length as needed
        public string Name { get; set; }
    }
}
