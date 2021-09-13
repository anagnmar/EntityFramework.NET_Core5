using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class Update__ForeignKeys_To_BookAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_Author_Id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_Book_Id",
                table: "BookAuthors");

            migrationBuilder.RenameColumn(
                name: "Book_Id",
                table: "BookAuthors",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "BookAuthors",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_Book_Id",
                table: "BookAuthors",
                newName: "IX_BookAuthors_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookAuthors",
                newName: "Book_Id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "BookAuthors",
                newName: "Author_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_Book_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_Author_Id",
                table: "BookAuthors",
                column: "Author_Id",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_Book_Id",
                table: "BookAuthors",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
