using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITodo.Domain.DTOs
{
    public class TodoDto
    {
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
    }
}