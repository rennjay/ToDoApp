using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Data.Repository;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController : ControllerBase
    {
        private readonly IToDoItemsRepository _toDoItemsRepository;
        public ToDoItemsController(IToDoItemsRepository toDoItemsRepository)
        {
            _toDoItemsRepository = toDoItemsRepository;

        }
        [HttpGet]
        public async Task<ActionResult> GetToDoItems()
        {
            var toDoItems = await _toDoItemsRepository.GetAllToDoItemsAsync();
            return Ok(toDoItems);
        }

        [HttpPost]
        public async Task<IActionResult> CreateToDoItem(ToDoItem toDo)
        {
            await _toDoItemsRepository.CreateToDoItemAsync(toDo);
            return CreatedAtAction("CreateToDoItem", toDo);
        }
    }
}