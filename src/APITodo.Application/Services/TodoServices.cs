using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITodo.Application.Interfaces;
using APITodo.Domain.DTOs;
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

        public async Task<Todo> AddTodo(TodoDto todo)
        {
            var newTodo = new Todo
            {
                Titulo = todo.Titulo,
                Descricao = todo.Descricao,
                DataCriacao = DateTime.Now
            };
            return await _todoRepository.AddTodo(newTodo);
        }

        public string IsValid(TodoDto todo)
        {
            if (string.IsNullOrWhiteSpace(todo.Titulo) && string.IsNullOrWhiteSpace(todo.Descricao))
            {
                return "Titulo e Descrição são obrigatórios.";
            }
            if (string.IsNullOrWhiteSpace(todo.Titulo))
            {
                return "Titulo é obrigatório.";
            }
            if (string.IsNullOrWhiteSpace(todo.Descricao))
            {
                return "Descrição é obrigatória.";
            }
            return string.Empty;
        }
    }
}