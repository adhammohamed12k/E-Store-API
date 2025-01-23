using for_holistic.DTO_s;

namespace for_holistic.Repository_s.OrderRepository
{
    public interface IOrderRepo
    {
        public void AddOrder(OnlyOrderDTO dto);
        public void UpdateOrder(OnlyOrderDTO dto , int id);

        public OnlyOrderDTO GetOrderById(int id);   
        
        public List<OnlyOrderDTO> GetAll();

        public void DeleteOrder(int id);
    }
}
