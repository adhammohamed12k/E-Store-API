using System.ComponentModel.DataAnnotations;

namespace for_holistic.Models
{
    public class Productt
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
