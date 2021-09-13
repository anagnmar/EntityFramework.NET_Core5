using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib_Model.Models
{
	[Table("tb_Genre")]
	public class Genre
	{
		public int GenreID { get; set; }

	//	[Column("Name")]
		public string GenreName { get; set; }


		// public int DisplayOrder { get; set; }

	}
}
