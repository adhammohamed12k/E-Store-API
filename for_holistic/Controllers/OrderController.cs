using for_holistic.DTO_s;
using for_holistic.Repository_s.CustomerrRepository;
using for_holistic.Repository_s.OrderRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace for_holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _Repo;

        public OrderController(IOrderRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("AddOrder")]

        public IActionResult AddOrder(OnlyOrderDTO dto)
        {
            _Repo.AddOrder(dto);
            return Ok(dto);
        }
        [HttpGet("GetOrderById")]
        public IActionResult GetOrderById(int id)
        {
            _Repo.GetOrderById(id);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _Repo.GetAll();
            return Ok(result);
        }
        [HttpPut("UpdateOrder")]
        public IActionResult UpdateOrder(OnlyOrderDTO dto, int id)
        {
            _Repo.UpdateOrder(dto, id);
            return Ok(dto);
        }
        [HttpDelete("DeleteOrder")]
        public IActionResult DeleteOrder(int id)
        {
            _Repo.DeleteOrder(id);
            return NoContent();
        }
    }
}
