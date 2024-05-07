using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RemovePasswordAlphanumericRequirement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70cc55e2-c1a2-4840-b8d1-8ffa3f7294c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be6c67dc-0f3e-4ad7-be86-104970b49010");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "567215f4-1f40-4f86-9d5c-790719437cc1", null, "User", "USER" },
                    { "7d76ac37-a05c-4bbe-8025-a852afb7382a", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "567215f4-1f40-4f86-9d5c-790719437cc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d76ac37-a05c-4bbe-8025-a852afb7382a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70cc55e2-c1a2-4840-b8d1-8ffa3f7294c8", null, "Admin", "ADMIN" },
                    { "be6c67dc-0f3e-4ad7-be86-104970b49010", null, "User", "USER" }
                });
        }
    }
}
