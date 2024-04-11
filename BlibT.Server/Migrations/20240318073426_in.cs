using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class @in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: true),
                    Favorits = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "David Johnson" },
                    { 4, "Emma Brown" },
                    { 5, "Michael Davis" },
                    { 6, "Sophia Miller" },
                    { 7, "Daniel Wilson" },
                    { 8, "Olivia Moore" },
                    { 9, "Ethan Lee" },
                    { 10, "Ava Anderson" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Favorits", "Likes", "Pages", "Title", "Views" },
                values: new object[] { 14, null, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Girl Who Played with Fire", 10 });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mystery" },
                    { 2, "Science Fiction" },
                    { 3, "Romance" },
                    { 4, "Thriller" },
                    { 5, "Fantasy" },
                    { 6, "Historical Fiction" },
                    { 7, "Biography" },
                    { 8, "Adventure" },
                    { 9, "Horror" },
                    { 10, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Favorits", "Likes", "Pages", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Da Vinci Code", 10 },
                    { 2, 2, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Dune", 10 },
                    { 3, 3, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Pride and Prejudice", 10 },
                    { 4, 4, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Girl with the Dragon Tattoo", 10 },
                    { 5, 5, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Harry Potter and the Sorcerer's Stone", 10 },
                    { 6, 6, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Great Gatsby", 10 },
                    { 7, 7, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Steve Jobs", 10 },
                    { 8, 8, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Hobbit", 10 },
                    { 9, 9, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "It", 10 },
                    { 10, 10, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Romeo and Juliet", 10 },
                    { 11, 2, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Hound of the Baskervilles", 10 },
                    { 12, 2, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Neuromancer", 10 },
                    { 13, 5, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Sense and Sensibility", 10 },
                    { 15, 5, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Harry Potter and the Chamber of Secrets", 10 },
                    { 16, 6, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "To Kill a Mockingbird", 10 },
                    { 17, 7, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Einstein: His Life and Universe", 10 },
                    { 18, 8, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Lord of the Rings", 10 },
                    { 19, 3, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "The Shining", 10 },
                    { 20, 10, "Some text", 10, 10, "[\"text\",\"from\",\"book\"]", "Macbeth", 10 }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
