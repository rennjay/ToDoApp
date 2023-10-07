using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Data.Repository
{
    public interface IToDoItemsRepository
    {
        Task CreateToDoItemAsync(ToDoItem toDo);
        Task<IEnumerable<ToDoItem>> GetAllToDoItemsAsync();
    }
}