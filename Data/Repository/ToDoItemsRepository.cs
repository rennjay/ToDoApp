using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Data.Repository
{
    public class ToDoItemsRepository : IToDoItemsRepository
    {
        private readonly ToDoItemsContext _context;
        public ToDoItemsRepository(ToDoItemsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<IEnumerable<ToDoItem>> GetAllToDoItemsAsync()
        {
            var toDoItems = await _context.ToDoItems.ToListAsync();
            return toDoItems;
        }

        public async Task CreateToDoItemAsync(ToDoItem toDo)
        {
            await _context.ToDoItems.AddAsync(toDo);
            await _context.SaveChangesAsync();
        }
    }
}