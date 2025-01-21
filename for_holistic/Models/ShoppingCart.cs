using System.ComponentModel.DataAnnotations;

namespace for_holistic.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }
        [Required]
        public int NumberOfItems { get; set; }

        public Customerr Customerr { get; set; }
    }
}
