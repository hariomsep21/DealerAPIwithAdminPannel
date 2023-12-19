using System.ComponentModel.DataAnnotations;

namespace AdminPannel_API.Models.DTO
{
    public class StateDTO
    {
        public int StateId { get; set; }
        [Required]
        [MaxLength(50)]
        public string StateName { get; set; }
    }
}
