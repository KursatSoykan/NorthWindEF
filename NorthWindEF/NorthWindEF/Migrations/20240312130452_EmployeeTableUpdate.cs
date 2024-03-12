using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWindEF.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportToEmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportToEmployeeId",
                table: "Employees");
        }
    }
}
