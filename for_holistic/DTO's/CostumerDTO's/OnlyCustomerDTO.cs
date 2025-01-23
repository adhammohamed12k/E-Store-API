using System.ComponentModel.DataAnnotations;

namespace for_holistic.DTO_s
{
    public class OnlyCustomerDTO
    {
        [Required]
        [StringLength(50)]
        public string CustomerrName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
