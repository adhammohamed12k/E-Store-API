using for_holistic.DTO_s;
using for_holistic.Models;

namespace for_holistic.Repository_s.ProducttRepository
{
    public class ProductRepo:IProductRepo
    {
        private readonly AppDbContextt _context;

        public ProductRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddProduct(OnlyProductDTO dto)
        {
            Productt productt = new Productt()
            {
                ProductName = dto.ProductName,
                Description = dto.Description,
                StockQuantity = dto.StockQuantity,
            };
            _context.productts.Add(productt);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var res = _context.productts.FirstOrDefault(f => f.ProductId == id);
            if (res != null)
            { 
                _context.productts.Remove(res);
                _context.SaveChanges();
            }
        }

        public List<OnlyProductDTO> GetAll()
        {
            var res = _context.productts.Select(c => new OnlyProductDTO
            { 
                ProductName = c.ProductName,
                Description = c.Description,
                StockQuantity = c.StockQuantity,
            }).ToList();
            return res;
        }

        public OnlyProductDTO GetById(int id)
        {
            var res = _context.productts.FirstOrDefault(d => d.ProductId == id);

            return new OnlyProductDTO
            {
                ProductName = res.ProductName,
                Description = res.Description,
                StockQuantity = res.StockQuantity,
            };
        }

        public void UpdateProduct(OnlyProductDTO dto , int id)
        {
           var res = _context.productts.FirstOrDefault(c => c.ProductId == id);
            res.ProductName = dto.ProductName;
            res.Description = dto.Description;
            res.StockQuantity = dto.StockQuantity;

            _context.productts.Update(res);
            _context.SaveChanges();

        }

       
    }
}
