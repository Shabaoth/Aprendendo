using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;
using TodoList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TodoList.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user)
        {
            return await _context.Items
                .Where(x => x.Status == false && x.UserId == user.Id )
                .ToArrayAsync();
            
        }

		public async Task<bool> AddItemAsync(TodoItem newItem)
		{
			newItem.Id = Guid.NewGuid();
			newItem.Status = false;
			if (newItem.Prazo == null)
			{
				newItem.Prazo = DateTimeOffset.Now.AddDays(4);
			}

			_context.Items.Add(newItem);

			var saveResult = await _context.SaveChangesAsync();
			return saveResult == 1;
		}

		public async Task<bool> MarkDoneAsync(Guid id)
		{
			var item = await _context.Items
				.Where(x => x.Id == id)
				.SingleOrDefaultAsync();

			if (item == null) return false;

			item.Status = true;

			var saveResult = await _context.SaveChangesAsync();
			return saveResult == 1; // One entity should have been updated
		}
    }	
}