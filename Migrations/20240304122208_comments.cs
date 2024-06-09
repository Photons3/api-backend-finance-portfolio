using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187fd1cf-0ef5-4bc6-bcb0-9b7d48d88376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "726eba3b-0f50-4a57-a939-6f023a199a49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62d97899-1171-4dc6-a215-ca537532d934", null, "Admin", "ADMIN" },
                    { "9dd8680d-db89-4bc5-a4a6-4d2d4195d594", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d97899-1171-4dc6-a215-ca537532d934");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd8680d-db89-4bc5-a4a6-4d2d4195d594");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "187fd1cf-0ef5-4bc6-bcb0-9b7d48d88376", null, "User", "USER" },
                    { "726eba3b-0f50-4a57-a939-6f023a199a49", null, "Admin", "ADMIN" }
                });
        }
    }
}
