using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APITodo.Application.Interfaces;
using APITodo.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITodo.Controllers
{
    [Route("[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoServices _todoServices;
        private readonly ILogger<TodoController> _logger;


        public TodoController(ILogger<TodoController> logger, ITodoServices todoServices)
        {
            _logger = logger;
            _todoServices = todoServices;
        }
        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] Todo todo)
        {
            var createdTodo = await _todoServices.AddTodo(todo);
            return CreatedAtAction(nameof(AddTodo), new { id = createdTodo.Id }, createdTodo);
        }
    }
}