using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoItem
    {
		public string UserId {get; set;}

        public Guid Id { get; set; }

        public bool Status { get; set; }

        [Required]
        public string Titulo { get; set; }

        public DateTimeOffset? Prazo { get; set; }
    }
}