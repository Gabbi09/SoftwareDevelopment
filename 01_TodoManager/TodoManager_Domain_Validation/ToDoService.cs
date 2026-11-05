using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager_Domain_Validation
{
    internal class ToDoService
    {
        //private readonly static List<TodoItem> todos = new List<TodoItem>();
        //private static int nextId = 1;

        private readonly TodoStorage storage;

        public ToDoService (TodoStorage storage)
        {
            this.storage = storage;
        }


        public TodoItem FindById(int id)
        {
            TodoItem targetTodo = null;
            foreach (TodoItem todoItem in storage.Todos)
            {
                if (todoItem.Id == id)
                {
                    return todoItem;
                }

            }

            return null;
        }


        public IReadOnlyList<TodoItem> GetAll() 
        { 
            return storage.Todos; 
        }

        public void Add(string title, string description, DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(storage.NextId, title, description, dueDate);
            storage.Todos.Add(todoItem);
            storage.NextId++;
        }

        public void Complete(int id)
        {
            TodoItem completedTask = FindById(id);

            if (completedTask == null)
                throw new ArgumentException("Няма задача с такова ID. ");
            completedTask.Completed();
        }

        public void Delete(int id)
        {
            TodoItem deleteTask = FindById(id);


            if(deleteTask == null)
                throw new ArgumentException("Няма задача с такова ID. ");
          
            storage.Todos.Remove(deleteTask);
        }

        
    }

}
