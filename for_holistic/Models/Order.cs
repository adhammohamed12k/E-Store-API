using System.ComponentModel.DataAnnotations;

namespace for_holistic.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public List<Productt> productts { get; set; }
        public int CustomerrId { get; set; }
        public Customerr Customerr { get; set; }
    }
}
