using for_holistic.DTO_s;
using for_holistic.Models;

namespace for_holistic.Repository_s.OrderRepository
{
    public class ShoppingCartRepo : IShoppingCartRepo
    {
        private readonly AppDbContextt _context;

        public ShoppingCartRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddCart(OnlyCartDTO dto)
        {
            ShoppingCart cart = new ShoppingCart()
            {
                NumberOfItems = dto.NumberOfItems,  
            };
            _context.shoppingCarts.Add(cart);
            _context.SaveChanges();
        }

        public void DeleteCart(int id)
        {
            var res = _context.shoppingCarts.FirstOrDefault(d => d.ShoppingCartId == id);

            if (res != null) 
            { 
                _context.shoppingCarts.Remove(res);
                _context.SaveChanges();
            }
        }

        public List<OnlyCartDTO> GetAll()
        {
            var res = _context.shoppingCarts.Select(x => new OnlyCartDTO
            {
                NumberOfItems= x.NumberOfItems,
            }).ToList();
            return res;
        }

        public OnlyCartDTO GetCartById(int id)
        {
            var res = _context.shoppingCarts.FirstOrDefault(d => d.ShoppingCartId == id);

            return new OnlyCartDTO
            {
                NumberOfItems = res.NumberOfItems
            };
        }

        public void UpdateCart(OnlyCartDTO dto, int id)
        {
           var res = _context.shoppingCarts.FirstOrDefault(s => s.ShoppingCartId == id);

            res.NumberOfItems = dto.NumberOfItems;

            _context.shoppingCarts.Update(res);
            _context.SaveChanges(); 
        }
    }
}
