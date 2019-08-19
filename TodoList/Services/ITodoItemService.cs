using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;
using Microsoft.AspNetCore.Identity;

namespace TodoList.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);

		Task<bool> AddItemAsync(TodoItem newItem);

		Task<bool> MarkDoneAsync(Guid id);

    }
}