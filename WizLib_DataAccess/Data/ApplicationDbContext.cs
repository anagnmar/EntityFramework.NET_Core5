using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using WizLib_Model.Models;
using WizLib_Model.Models_FluentAPI;


namespace WizLib_DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Genre> Genres { get; set; }
		public DbSet<Book> Books { get; set; }

		public DbSet<BookDetail> BookDetails { get; set; }

		public DbSet<Author> Authors { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<BookAuthor> BookAuthors { get; set; }

	//	Fluent  models

		public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
		public DbSet<Fluent_Author> Fluent_Authors { get; set; }
		public DbSet<Fluent_Book> Fluent_Books { get; set; }
		public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }


		/*
			public DbSet<Fluent_Author> MyProperty { get; set; }
			public DbSet<Fluent_Book> Fluent_Books { get; set; }
			public DbSet<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }
			public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
			public DbSet<Fluent_Publisher> fluent_Publishers { get; set; }
		*/

	#region		Fluent Api

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BookAuthor>()          // composite key
							.HasKey(ba => new { ba.AuthorId, ba.BookId } ); 

			//	Fluent_BookDetail
			modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);
													//.HasKey("BookDetail_Id");
			modelBuilder.Entity<Fluent_BookDetail>().Property(b => b.NumberOfChapters)
							.IsRequired();
													//.Property("NumberOfChapters")
													//.IsRequired();

			//	Fluent Book
			modelBuilder.Entity<Fluent_Book>()
							.HasKey(fb => fb.Book_Id);
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.ISBN)
							.HasMaxLength(15)
							.IsRequired();
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.Title)
							.IsRequired();
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.Price)
							.IsRequired();

			//	Fluent Author
			modelBuilder.Entity<Fluent_Author>()
							.HasKey(fa => fa.Author_Id);
			modelBuilder.Entity<Fluent_Author>()
							.Property(fa => fa.FirstName)
							.IsRequired();
			modelBuilder.Entity<Fluent_Author>()
							.Property(fa => fa.LastName)
							.IsRequired();
			modelBuilder.Entity<Fluent_Author>()
							.Ignore(fa => fa.FullName);

			//	Fluent_Publisher
			modelBuilder.Entity<Fluent_Publisher>()
							.HasKey(fa => fa.Publisher_Id);
			modelBuilder.Entity<Fluent_Publisher>()
							.Property(fa => fa.Name)
							.IsRequired();
			modelBuilder.Entity<Fluent_Publisher>()
							.Property(fa => fa.Location)
							.IsRequired();

		}

	#endregion

	}
}
