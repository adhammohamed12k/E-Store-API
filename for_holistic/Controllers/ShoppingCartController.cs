using for_holistic.DTO_s;
using for_holistic.Repository_s.CustomerrRepository;
using for_holistic.Repository_s.OrderRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace for_holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartRepo _Repo;

        public ShoppingCartController(IShoppingCartRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("AddCart")]
        public IActionResult AddCart(OnlyCartDTO dto)
        {
            _Repo.AddCart(dto);
            return Ok(dto);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
           var dd=  _Repo.GetAll();
            return Ok(dd);
        }
        [HttpGet("GetCartById")]
        public IActionResult GetCartById(int id)
         {
            var re = _Repo.GetCartById(id);
            return Ok(re);
         }
        [HttpPut("UpdateCart")]
        public IActionResult UpdateCart(OnlyCartDTO dto, int id)
        {
           _Repo.UpdateCart( dto,id);
            return Ok(dto);
        }
        [HttpDelete("DeleteCart")]
        public IActionResult DeleteCart(int id)
        {
            _Repo.DeleteCart(id);
            return NoContent();
        }
    }
}
