using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcTodo.Data;
using System;
using System.Linq;

namespace MvcTodo.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcTodoContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcTodoContext>>()))
            {
                // Look for any movies.
                if (context.TodoItem.Any())
                {
                    return;   // DB has been seeded
                }

                context.TodoItem.AddRange(
                    new TodoItem
                    {
                        Title = "Learn about WinForms",
                        CreationDate = DateTime.Parse("2021-7-9"),
                        isComplete = true
                    },

                    new TodoItem
                    {
                        Title = "Learn about SQL",
                        CreationDate = DateTime.Parse("2021-7-10"),
                        isComplete = true
                    },

                    new TodoItem
                    {
                        Title = "Learn about stored procedures",
                        CreationDate = DateTime.Parse("2021-7-10"),
                        isComplete = true
                    },

                    new TodoItem
                    {
                        Title = "Learn about MVC pattern",
                        CreationDate = DateTime.Parse("2021-7-16"),
                        isComplete = false
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
