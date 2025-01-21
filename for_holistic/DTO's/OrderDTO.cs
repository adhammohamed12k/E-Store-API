using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class OrderDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public List<ProducttDTO> Productt { get; set; }
    }
}
