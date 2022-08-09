using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P127Onion.Application.Interfaces.Repositories;
using P127Onion.Domain.Entities;

namespace P127Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;

        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Get(int id)
        {
            if(id==0) return BadRequest(new
            {
                code = "id",
                desc = "You cannot set id to 0"
            });
            Category category = await _repository.GetById(id);    
            if (category==null) return NotFound();
            return Ok(category);
        }
    }
}
