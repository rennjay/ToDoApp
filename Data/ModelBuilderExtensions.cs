using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem { Id = 1, Title = "Buy Rice", Description = "Description to buy rice" },
                new ToDoItem { Id = 2, Title = "Exercise", Description = "Go to the Gym" },
                new ToDoItem { Id = 3, Title = "Send Email", Description = "Send follow up email regarding ABC" }
            );
        }
    }
}