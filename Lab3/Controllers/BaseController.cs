using Lab3.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseController<TDto> : Controller
        where TDto : class, new()
    {
        protected IService<TDto> Service { get; }
        public BaseController(IService<TDto> service)
        {
            Service = service;
        }
    }
}

