using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class docxFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a15a28-c558-4ef8-bcbd-52d09a27a0bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f121104d-f293-43e4-a247-5b5041ca9aab");

            migrationBuilder.AddColumn<string>(
                name: "DocxFileName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14a1e21f-f624-4992-9677-0b26596dd899", null, "Administrator", "ADMINISTRATOR" },
                    { "50281bb2-6d8b-4f53-85ff-59f708d06c6a", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 18, 93, 42m, 44 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 7, 33, 42m, 21 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 15, 0, 37m, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 24, 0, 36m, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 0, 11, 23m, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 20, 50, 28m, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 5, 96, 36m, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 5, 51, 25m, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 19, 19, 37m, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 27, 37, 10m, 26 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 5, 12, 36m, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 18, 2, 49m, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 0, 7, 21m, 34 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 13, 99, 42m, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 11, 44, 42m, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 27, 20, 43m, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 10, 39, 47m, 45 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 26, 8, 49m, 49 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 20, 46, 37m, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DocxFileName", "Favorits", "Likes", "Price", "Views" },
                values: new object[] { null, 9, 64, 45m, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a1e21f-f624-4992-9677-0b26596dd899");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50281bb2-6d8b-4f53-85ff-59f708d06c6a");

            migrationBuilder.DropColumn(
                name: "DocxFileName",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61a15a28-c558-4ef8-bcbd-52d09a27a0bb", null, "Administrator", "ADMINISTRATOR" },
                    { "f121104d-f293-43e4-a247-5b5041ca9aab", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 5, 3, 32m, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 26, 10, 26m, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 27, 9, 16m, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 20, 18m, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 25, 50, 33m, 23 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 9, 98, 43m, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 26, 18m, 29 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 7, 46, 45m, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 1, 24, 22m, 25 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 6, 12, 29m, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 15, 35, 25m, 48 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 14, 69, 37m, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 21, 82, 30m, 44 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 8, 56, 13m, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 5, 53, 31m, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 14, 53, 36m, 49 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 6, 42, 31m, 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 26, 12m, 39 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 8, 62, 32m, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 21, 40, 18m, 11 });
        }
    }
}
