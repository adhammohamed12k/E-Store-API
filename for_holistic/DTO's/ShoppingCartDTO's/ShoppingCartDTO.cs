using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class ShoppingCartDTO
    {
        [Required]
        public int NumberOfItems { get; set; }    }
}
