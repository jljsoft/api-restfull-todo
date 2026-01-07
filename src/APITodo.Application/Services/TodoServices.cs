using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITodo.Application.Interfaces;
using APITodo.Domain.Models;
using APITodo.Infrastructure.Interfaces;

namespace APITodo.Application.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly ITodoRepository _todoRepository;

        public TodoServices(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Todo> AddTodo(Todo todo)
        {
            return await _todoRepository.AddTodo(todo);
        }
    }
}