using for_holistic.DTO_s;
using for_holistic.Models;
using Microsoft.EntityFrameworkCore;

namespace for_holistic.Repository_s.OrderRepository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContextt _context;

        public OrderRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddOrder(OnlyOrderDTO dto)
        {
            Order order = new Order()
            {
                TotalPrice = dto.TotalPrice,
            };
            _context.orders.Add(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
           var res = _context.orders.FirstOrDefault(d => d.OrderId == id);
            if (res != null) 
            { 
                _context.orders.Remove(res);    
                 _context.SaveChanges();
            }
        }

        public List<OnlyOrderDTO> GetAll()
        {
            var res  = _context.orders.Select(a => new OnlyOrderDTO
            {
                TotalPrice = a.TotalPrice,
            }).ToList();
            return res;
        }

        public OnlyOrderDTO GetOrderById(int id)
        {
           var rees = _context.orders.FirstOrDefault(d => d.OrderId == id);
           
            return new OnlyOrderDTO
            {
                TotalPrice = rees.TotalPrice
            };
        }

        public void UpdateOrder(OnlyOrderDTO dto, int id)
        {
           var res = _context.orders.FirstOrDefault(x => x.OrderId == id);
            res.TotalPrice = dto.TotalPrice;

            _context.orders.Update(res);
            _context.SaveChanges();
        }
    }
}
