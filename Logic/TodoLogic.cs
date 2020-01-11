using FirstBlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace FirstBlazorApp.Logic
{
    public class TodoLogic : ComponentBase
    {
        protected IList<TodoItem> todos = new List<TodoItem>();
        protected string newTodo;

        protected void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}