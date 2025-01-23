using for_holistic.DTO_s;

namespace for_holistic.Repository_s.OrderRepository
{
    public interface IShoppingCartRepo
    {
        public void AddCart(OnlyCartDTO dto);

        public void UpdateCart(OnlyCartDTO dto , int id);

        public void DeleteCart(int id);

        public OnlyCartDTO GetCartById(int id);

        public List<OnlyCartDTO> GetAll();
    }
}
