using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d0dc77d-a6ca-4b98-8659-2fc76060cccb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80fba7ea-a0cd-4aaa-bb7f-c2f51cbd48c1");

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
                columns: new[] { "Likes", "Price", "Views" },
                values: new object[] { 46, 45m, 24 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a15a28-c558-4ef8-bcbd-52d09a27a0bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f121104d-f293-43e4-a247-5b5041ca9aab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d0dc77d-a6ca-4b98-8659-2fc76060cccb", null, "Moderator", "MODERATOR" },
                    { "80fba7ea-a0cd-4aaa-bb7f-c2f51cbd48c1", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 96, 49m, 19 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 24, 28, 35m, 19 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 15, 72, 27m, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 19, 4, 41m, 43 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 23, 60, 39m, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 28, 71, 20m, 44 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 27, 55, 26m, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Likes", "Price", "Views" },
                values: new object[] { 85, 14m, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 24, 53, 10m, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 88, 35m, 46 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 22, 2, 45m, 36 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 29, 65, 20m, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 15, 3, 36m, 46 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 24, 22, 40m, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 9, 20, 14m, 20 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 26, 63, 42m, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 27, 14, 14m, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 16, 92, 15m, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 24, 71, 13m, 42 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 18, 25, 15m, 44 });
        }
    }
}
