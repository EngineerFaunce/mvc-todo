using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcTodo.Models
{
	// used in TodoItems Index view in order to show all todo items
	// and allow creating a new todo item
    public class TodoModel
    {
		public int Id { get; set; }
		public string Title { get; set; }

		[Display(Name = "Creation Date")]
		[DataType(DataType.Date)]
		public DateTime CreationDate { get; set; }

		[Display(Name = "Is Complete")]
		public bool isComplete { get; set; }

		public IEnumerable<TodoItem> items { get; set; }
	}
}
