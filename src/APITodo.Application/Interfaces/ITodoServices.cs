using System;
using APITodo.Domain.DTOs;
using APITodo.Domain.Models;

namespace APITodo.Application.Interfaces;

public interface ITodoServices
{
    Task<Todo> AddTodo(TodoDto todo);
    string IsValid(TodoDto todo);
    string IsValidLength(TodoDto todo);
}
