using System;
using APITodo.Domain.Models;
using APITodo.Infrastructure.Context;
using APITodo.Infrastructure.Interfaces;

namespace APITodo.Infrastructure.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;

    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Todo> AddTodo(Todo todo)
    {
        await _context.Todos.AddAsync(todo);
        await _context.SaveChangesAsync();
        return todo;
    }
}
