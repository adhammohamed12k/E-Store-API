using for_holistic.DTO_s;
using for_holistic.Repository_s.CustomerrRepository;
using for_holistic.Repository_s.ProducttRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace for_holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _Repo;

        public ProductController(IProductRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("AddProduct")]

        public IActionResult AddProduct(OnlyProductDTO dto)
        {
            _Repo.AddProduct(dto);
            return Ok(dto);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            _Repo.GetById(id);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _Repo.GetAll();
            return Ok(result);
        }
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(OnlyProductDTO dto, int id)
        {
            _Repo.UpdateProduct(dto, id);
            return Ok(dto);
        }
        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            _Repo.DeleteProduct(id);
            return NoContent();
        }
    }
}
