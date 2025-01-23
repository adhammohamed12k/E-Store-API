using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class OnlyOrderDTO
    {
        [Required]
        public int TotalPrice { get; set; }
    }
}
