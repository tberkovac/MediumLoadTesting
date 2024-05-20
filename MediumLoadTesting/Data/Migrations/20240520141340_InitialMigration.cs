using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediumLoadTesting.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorName", "Name", "PublishedAt" },
                values: new object[,]
                {
                    { 1, "AuthorName 1", "Name 1", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2500) },
                    { 2, "AuthorName 2", "Name 2", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2500) },
                    { 3, "AuthorName 3", "Name 3", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510) },
                    { 4, "AuthorName 4", "Name 4", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510) },
                    { 5, "AuthorName 5", "Name 5", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510) },
                    { 6, "AuthorName 6", "Name 6", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510) },
                    { 7, "AuthorName 7", "Name 7", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520) },
                    { 8, "AuthorName 8", "Name 8", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520) },
                    { 9, "AuthorName 9", "Name 9", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520) },
                    { 10, "AuthorName 10", "Name 10", new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
