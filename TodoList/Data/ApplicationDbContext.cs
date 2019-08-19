﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		 protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// ...
		}
		public DbSet<TodoItem> Items { get; set; }

    }
}
