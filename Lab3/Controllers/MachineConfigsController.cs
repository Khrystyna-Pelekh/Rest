﻿using System;
using System.Collections.Generic;
using Lab3.Services;
using Lab3.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineConfigsController : BaseController<MachineConfig>
    {
        public MachineConfigsController(IService<MachineConfig> service)
            : base(service)
        {
        }

        // GET: api/<MachineConfigsController>
        [HttpGet]
        public ActionResult<IEnumerable<MachineConfig>> Get()
        {
            return Ok(Service.Get());
        }

        // GET api/<MachineConfigsController>/5
        [HttpGet("{id}")]
        public ActionResult<MachineConfig> Get(int id)
        {
            var response = Service.Get(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPatch("{id}")]
        public ActionResult Patch(int id, [FromBody] PatchModel patch)
        {
            try
            {
                Service.Update(id, patch);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok();
        }
    }
}
