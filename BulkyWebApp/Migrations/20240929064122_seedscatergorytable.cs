using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class seedscatergorytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "ID", "Display_Order", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Ahmed" },
                    { 2, 1, "Hamza" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catergories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catergories",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
