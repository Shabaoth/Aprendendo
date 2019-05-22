using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public bool Status { get; set; }

        [Required]
        public string Descricao { get; set; }

        public DateTimeOffset? DataConclusao { get; set; }
    }
}