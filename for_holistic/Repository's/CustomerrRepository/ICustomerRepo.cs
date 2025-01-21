using for_holistic.DTO_s;

namespace for_holistic.Repository_s.CustomerrRepository
{
    public interface ICustomerRepo
    {
        public void AddAll(AddCostumerWithAll dto);

        public List<AddCostumerWithAll> GetAll();

        public AddCostumerWithAll GetById(int id);

        public void Update(AddCostumerWithAll dto , int id);

        public void Delete(int id);
    }
}
