using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class smallfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26f93e82-3145-49d4-8ad9-69c2fccf243a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77b801d5-eb8b-45cd-a93b-dd015a675070");

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50f37a61-dd29-4b2f-be0d-33c2fa48e935", null, "Moderator", "MODERATOR" },
                    { "75cb8360-b956-44cf-aeb5-7b3f1704fa97", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 3 },
                    { 4, 4 },
                    { 6, 4 },
                    { 7, 6 },
                    { 8, 5 },
                    { 9, 7 },
                    { 11, 6 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 5 },
                    { 15, 8 },
                    { 16, 1 },
                    { 18, 7 },
                    { 19, 3 },
                    { 20, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 23, 40, 32m, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 21, 45, 15m, 23 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 0, 75, 20m, 47 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 8, 31, 13m, 44 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 20, 74, 45m, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 22, 6, 18m, 26 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 2, 28m, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 8, 47, 42m, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 20, 68, 32m, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 2, 83, 45m, 19 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 5, 40, 34m, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 15, 61, 13m, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 25, 67, 14m, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 16, 41, 12m, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 12, 14, 45m, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 10, 72, 44m, 27 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 26, 4, 13m, 46 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 15, 67, 38m, 49 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 7, 89, 42m, 40 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Favorits", "Likes", "Price", "Views" },
                values: new object[] { 10, 10, 16m, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f37a61-dd29-4b2f-be0d-33c2fa48e935");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75cb8360-b956-44cf-aeb5-7b3f1704fa97");

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.AddColumn<string>(
                name: "Pages",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26f93e82-3145-49d4-8ad9-69c2fccf243a", null, "Administrator", "ADMINISTRATOR" },
                    { "77b801d5-eb8b-45cd-a93b-dd015a675070", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 5 },
                    { 3, 2 },
                    { 4, 8 },
                    { 6, 1 },
                    { 7, 3 },
                    { 8, 7 },
                    { 9, 3 },
                    { 11, 1 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 6 },
                    { 15, 2 },
                    { 16, 3 },
                    { 18, 9 },
                    { 19, 6 },
                    { 20, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 18, 86, null, 14m, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 13, 6, null, 14m, 47 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 6, 35, null, 47m, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 13, 70, null, 38m, 20 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 12, 78, null, 28m, 43 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 4, 96, null, 30m, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 7, 45, null, 11m, 28 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 19, 62, null, 35m, 19 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 12, 46, null, 14m, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 21, 75, null, 11m, 47 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 24, 3, null, 25m, 35 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 17, 73, null, 15m, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 1, 21, null, 17m, 24 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 8, 11, null, 38m, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 2, 44, null, 43m, 48 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 19, 13, null, 37m, 29 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 6, 11, null, 33m, 31 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 7, 11, null, 29m, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 14, 69, null, 44m, 30 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Favorits", "Likes", "Pages", "Price", "Views" },
                values: new object[] { 21, 86, null, 21m, 6 });
        }
    }
}
