using for_holistic.DTO_s;

namespace for_holistic.Repository_s.ProducttRepository
{
    public interface IProductRepo
    {
        public void AddProduct(OnlyProductDTO dto);

        public void UpdateProduct(OnlyProductDTO dto , int id);

        public void DeleteProduct(int id);

        public OnlyProductDTO GetById(int id);

        public List<OnlyProductDTO> GetAll();
    }
}
