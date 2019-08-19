using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
using TodoList.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace TodoList.Controllers
{	
	[Authorize]
    public class TodoController : Controller
   {
		private readonly ITodoItemService _todoItemService;
		private readonly UserManager<IdentityUser> _userManager;


		public TodoController(ITodoItemService todoItemService,
			UserManager<IdentityUser> userManager)
		{
			_todoItemService = todoItemService;
			_userManager = userManager;
		}

        // Actions go here
        public async Task<IActionResult> Index()
		{

			//Validating login
			var currentUser = await _userManager.GetUserAsync(User);
			if (currentUser == null) return Challenge();	


			// Get to-do items from database
			var items = await _todoItemService
				.GetIncompleteItemsAsync(currentUser);

			// Put items into a model
			var model = new TodoViewModel()
			{
				Items = items
			};	
			// Render view using the model
			return View(model);
		}

		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddItem(TodoItem newItem)
		{
			if (!ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			var successful = await _todoItemService.AddItemAsync(newItem);
			if (!successful)
			{
				return BadRequest("N�o � poss�vel adicionar um item");
			}

			return RedirectToAction("Index");
		}

		[ValidateAntiForgeryToken]
		public async Task<IActionResult> MarkDone(Guid id)
		{
			if (id == Guid.Empty)
			{
				return RedirectToAction("Index");
			}

			var successful = await _todoItemService.MarkDoneAsync(id);
			if (!successful)
			{
				return BadRequest("Could not mark item as done.");
			}

			return RedirectToAction("Index");
		}
	}

}