using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib_Model.Models
{
	public class BookAuthor
	{
		//	composite key **

		[ForeignKey("Book")]
		public int BookId { get; set; }
		[ForeignKey("Author")]
		public int AuthorId { get; set; }


	//	navigation properties

		public Book Book { get; set; }

		public Author Author { get; set; }

	}
}
