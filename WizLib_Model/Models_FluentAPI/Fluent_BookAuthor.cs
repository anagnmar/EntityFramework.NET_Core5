using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib_Model.Models_FluentAPI
{
	public class Fluent_BookAuthor
	{
	//	[Key]				composite key
		public int Book_Id { get; set; }

	//	[Key]				composite key
		public int Author_Id { get; set; }


			/*	navigation properties

				public Fluent_Book Book { get; set; }

				public Fluent_Author Author { get; set; }
			*/

	}
}
