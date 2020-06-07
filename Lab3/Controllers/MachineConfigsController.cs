using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineConfigsController : ControllerBase
    {
        private readonly Context.ApiContext _context;
        public MachineConfigsController(Context.ApiContext context)
        {
            _context = context;
        }

        // GET: api/<MachineConfigsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MachineConfigsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MachineConfigsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<MachineConfigsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]MachineConfig value)
        {
            var machine = _context.MachineConfigs.Find(id);
            if (machine == null)
            {
                return NotFound();
            }
            else
            {
                value.Id = id;
                if (value.CurrentCapacity < value.MaxCapacity)
                {
                    _context.Entry(machine).CurrentValues.SetValues(value);
                    _context.SaveChanges();
                    return Ok(machine);
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        // DELETE api/<MachineConfigsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
