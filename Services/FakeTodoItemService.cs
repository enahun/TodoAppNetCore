using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
namespace AspNetCoreTodo.Services
{
    public class FatkeTodoItemServices
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title="Primer tarea",
                DueAt =DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem{
                Title="Enviar a base de datos",
                DueAt=DateTimeOffset.Now.AddDays(2)
            };
            return Task.FromResult(new []{item1,item2});
        }
    }
}