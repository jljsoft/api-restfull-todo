using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITodo.Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}