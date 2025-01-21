using System.ComponentModel.DataAnnotations;

namespace for_holistic.Models
{
    public class Customerr
    {
        [Key]
        public int CustomerrId { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerrName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public List<Order> orders { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
