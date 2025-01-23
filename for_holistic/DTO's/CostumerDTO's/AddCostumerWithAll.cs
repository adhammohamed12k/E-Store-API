using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class AddCostumerWithAll
    {
        [Required]
        public string CustomerrName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public List<OrderDTO> ordersDto { get; set; }
        public ShoppingCartDTO shoppingCartDto { get; set; } // con >>, cart>> , pro , or>>

    }
}
