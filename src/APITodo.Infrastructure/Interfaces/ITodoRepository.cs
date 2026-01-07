using System;
using APITodo.Domain.Models;

namespace APITodo.Infrastructure.Interfaces;

public interface ITodoRepository
{
    Task<Todo> AddTodo(Todo todo);
}
