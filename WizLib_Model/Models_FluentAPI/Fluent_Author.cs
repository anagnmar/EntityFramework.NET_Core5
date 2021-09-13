using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib_Model.Models_FluentAPI
{
	public class Fluent_Author
	{
		[Key]
		public int Author_Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }
		public string Location { get; set; }

		[NotMapped]
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
	}
}
