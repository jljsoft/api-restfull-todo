using System;
using APITodo.Domain.Models;

namespace APITodo.Application.Interfaces;

public interface ITodoServices
{
    Task<Todo> AddTodo(Todo todo);
}
