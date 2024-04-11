using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlibT.Server.Migrations
{
    /// <inheritdoc />
    public partial class RoleCfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "919d3902-b879-4a71-8d07-b06f64730710", null, "Moderator", "MODERATOR" },
                    { "ba71bcb7-09a9-4201-90bb-ca31da4446bc", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "919d3902-b879-4a71-8d07-b06f64730710");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba71bcb7-09a9-4201-90bb-ca31da4446bc");
        }
    }
}
