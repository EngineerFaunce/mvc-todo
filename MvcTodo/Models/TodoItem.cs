using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTodo.Models
{
	public class TodoItem
	{
		public int Id { get; set; }
		public string Title { get; set; }

		[Display(Name = "Creation Date")]
		[DataType(DataType.Date)]
		public DateTime CreationDate { get; set; }

		[Display(Name = "Is Complete")]
		public bool isComplete { get; set; }
	}
}