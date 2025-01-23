using for_holistic.DTO_s;
using for_holistic.Models;
using Microsoft.EntityFrameworkCore;

namespace for_holistic.Repository_s.CustomerrRepository
{
    public class CustomerRepo: ICustomerRepo
    {
        private readonly AppDbContextt _context;

        public CustomerRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddAll(AddCostumerWithAll dto)
        {
            Customerr customerr = new Customerr
            { 
               CustomerrName = dto.CustomerrName,
               EmailAddress = dto.EmailAddress,
               Phone = dto.Phone,
               ShoppingCart = new ShoppingCart { NumberOfItems = dto.shoppingCartDto.NumberOfItems},
               orders = dto.ordersDto.Select(x => new Order
               {
                 TotalPrice = x.TotalPrice,
                 productts = x.Productt.Select(z => new Productt
                 {
                     ProductName = z.ProductName,
                     Description = z.Description,
                     StockQuantity = z.StockQuantity,
                 }).ToList(),
               }).ToList(),
            };
            _context.customerrs.Add(customerr);
            _context.SaveChanges();
        }



        public void Delete(int id)
        {
            var res = _context.customerrs.FirstOrDefault(x=> x.CustomerrId == id);
            if (res != null)
            {
                _context.customerrs.Remove(res);
                _context.SaveChanges();
            }
        }
        

        public List<AddCostumerWithAll> GetAll()
        {
            var res = _context.customerrs.
                Include(a => a.orders)
                .ThenInclude(b => b.productts)
                .Include(c => c.ShoppingCart).Select(d => new AddCostumerWithAll 
                {
                    CustomerrName = d.CustomerrName,
                    EmailAddress = d.EmailAddress,
                    Phone = d.Phone,
                    ordersDto = d.orders.Select(f => new OrderDTO
                    {
                        TotalPrice = f.TotalPrice,
                        Productt = f.productts.Select(s => new ProducttDTO
                        {
                            ProductName = s.ProductName,
                            Description = s.Description,
                            StockQuantity = s.StockQuantity,
                        }).ToList(),
                    }).ToList(),
                    shoppingCartDto = new ShoppingCartDTO { NumberOfItems = d.ShoppingCart.NumberOfItems },
                }).ToList();
            return res;
        }

        public AddCostumerWithAll GetById(int id)
        {
            var res = _context.customerrs.
                  Include(a => a.orders)
                  .ThenInclude(b => b.productts)
                  .Include(c => c.ShoppingCart).FirstOrDefault(x => x.CustomerrId == id);
            return new AddCostumerWithAll
            {
                CustomerrName = res.CustomerrName,
                EmailAddress = res.EmailAddress,
                Phone = res.Phone,
                shoppingCartDto = new ShoppingCartDTO { NumberOfItems= res.ShoppingCart.NumberOfItems },
                ordersDto = res.orders.Select(d=> new OrderDTO
                {
                    TotalPrice= d.TotalPrice,
                    Productt = d.productts.Select(g => new ProducttDTO
                    {
                        ProductName = g.ProductName,
                        Description = g.Description,
                        StockQuantity = g.StockQuantity,
                    }).ToList(),
                }).ToList(),
            };
        }

        public void Update(AddCostumerWithAll dto, int id)
        {
            var res = _context.customerrs.
                    Include(a => a.orders)
                    .ThenInclude(b => b.productts)
                    .Include(c => c.ShoppingCart).FirstOrDefault(x => x.CustomerrId == id);

            res.CustomerrName = dto.CustomerrName;
            res.EmailAddress = dto.EmailAddress;
            res.Phone = dto.Phone;
            res.ShoppingCart = new ShoppingCart { NumberOfItems = res.ShoppingCart.NumberOfItems, };
            res.orders = dto.ordersDto.Select(d => new Order
            {
                TotalPrice = d.TotalPrice,      
                productts = d.Productt.Select(e => new Productt
                {
                    ProductName= e.ProductName,
                    Description = e.Description,
                    StockQuantity= e.StockQuantity,
                }).ToList(),
            }).ToList();

            _context.customerrs.Update(res);
            _context.SaveChanges();
        }
    }
}
