using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class ProducttDTO
    {
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
