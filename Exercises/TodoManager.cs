using System;
using System.Collections.Generic;

namespace Coding.Exercise
{

    public class TodoManager
    {
        private List<TodoItem> todoItems;

        public TodoManager()
        {
            todoItems = new List<TodoItem>();
        }

        public void AddTodoItem(TodoItem item)
        {
            // Add logic to check if the item is null
            if(item == null)
            {
                throw new ArgumentNullException("Todo item cannot be null");
            }


            // Add logic to check if the item already exists
            foreach (var existingItem in todoItems)
            {
                if (existingItem.Id == item.Id)
                {
                    throw new ArgumentException("Todo item with the same ID already exists");
                }
            }


            // Add logic to check if the item's title is empty
            if (string.IsNullOrWhiteSpace(item.Title))
            {
                throw new ArgumentException("Todo item title cannot be empty");
            }


            // If all checks pass, add the item to the collection
            todoItems.Add(item);

            Console.WriteLine($"Todo item added: {item.Title}");
        }

        public TodoItem GetTodoItem(int id)
        {
            // Add logic to find the Todo item by ID
            TodoItem foundItem = null;
            foreach (var item in todoItems)
            {
                if (item.Id == id)
                {
                    foundItem = item;
                    break;
                }
            }

            // Add logic to handle when the item is not found
            if (foundItem == null)
            {
                throw new KeyNotFoundException("Todo item not found");
            }

            Console.WriteLine($"Todo item found: {foundItem.Title}");
            return foundItem;
        }

        public void MarkTodoItemCompleted(int id)
        {
            // Add logic to find the Todo item by ID
            TodoItem foundItem = null;
            foreach (var item in todoItems)
            {
                if (item.Id == id)
                {
                    foundItem = item;
                    break;
                }
            }


            // Add logic to handle when the item is not found
            if (foundItem == null)
            {
                throw new KeyNotFoundException("Todo item not found");
            }


            // Add logic to mark the item as completed
            foundItem.IsCompleted = true;

        }
    }
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

}

