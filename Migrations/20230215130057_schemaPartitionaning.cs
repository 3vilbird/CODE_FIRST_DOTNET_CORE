using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmapleCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class schemaPartitionaning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EP");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "EP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "EP",
                newName: "Employees");
        }
    }
}
