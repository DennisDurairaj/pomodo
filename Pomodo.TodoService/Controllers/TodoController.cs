using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pomodo.TodoService.Models;

namespace Pomodo.TodoService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TodoModel> Get()
        {
            var test = new List<TodoModel>();
            return test;
        }
    }
}