using System.Collections.Generic;
using Lab3.Services;
using Lab3.Services.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : BaseController<Ingredient>
    {
        public IngredientsController(IService<Ingredient> service)
            : base(service)
        {
        }
        // GET: api/<IngredientsController>
        [HttpGet]
        public ActionResult<IEnumerable<Ingredient>> Get()
        {
            return Ok(Service.Get());
        }
    }
}
