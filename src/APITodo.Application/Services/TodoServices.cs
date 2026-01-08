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
            
            try
            {
                var newTodo = new Todo
                {
                    Titulo = todo.Titulo,
                    Descricao = todo.Descricao,
                    DataCriacao = DateTime.Now
                };
                var result = await _todoRepository.AddTodo(newTodo);
                return result;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
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
        public string IsValidLength(TodoDto todo)
        {
            if (todo.Titulo.Length > 100)
            {
                return "Titulo deve ter no máximo 100 caracteres.";
            }
            if (todo.Descricao.Length > 1000)
            {
                return "Descrição deve ter no máximo 1000 caracteres.";
            }
            return string.Empty;
        }
    }
}