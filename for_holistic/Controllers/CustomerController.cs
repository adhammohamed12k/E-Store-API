using for_holistic.DTO_s;
using for_holistic.Repository_s.CustomerrRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace for_holistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _Repo;

        public CustomerController(ICustomerRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost("AddAll")]
        public IActionResult AddAll(AddCostumerWithAll dto)
        {
            _Repo.AddAll(dto);
            return Ok(dto);
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
           var dd=  _Repo.GetAll();
            return Ok(dd);
        }
        [HttpGet("GetById")]
         public IActionResult GetById(int id)
         {
            var re = _Repo.GetById(id);
            return Ok(re);
         }
        [HttpPut]
        public IActionResult Update(AddCostumerWithAll dto, int id)
        {
           _Repo.Update( dto,id);
            return Ok(dto);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            _Repo.Delete(id);
            return NoContent();
        }
    }
}
