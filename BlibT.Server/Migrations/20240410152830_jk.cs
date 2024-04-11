using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class jk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "919d3902-b879-4a71-8d07-b06f64730710");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba71bcb7-09a9-4201-90bb-ca31da4446bc");

            migrationBuilder.CreateTable(
                name: "UserBookFavorite",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBookFavorite", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserBookFavorite_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBookFavorite_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBookLike",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBookLike", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserBookLike_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBookLike_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69638f9e-6cfd-46ef-920d-98d83bad8a4f", null, "Administrator", "ADMINISTRATOR" },
                    { "eecf392f-333b-4aec-bcf9-a4ed607b52ed", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBookFavorite_UserId",
                table: "UserBookFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBookLike_UserId",
                table: "UserBookLike",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBookFavorite");

            migrationBuilder.DropTable(
                name: "UserBookLike");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69638f9e-6cfd-46ef-920d-98d83bad8a4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eecf392f-333b-4aec-bcf9-a4ed607b52ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "919d3902-b879-4a71-8d07-b06f64730710", null, "Moderator", "MODERATOR" },
                    { "ba71bcb7-09a9-4201-90bb-ca31da4446bc", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
