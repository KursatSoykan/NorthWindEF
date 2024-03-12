using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWindEF.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeId",
                table: "Employees",
                newName: "ReportsToEmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeID",
                table: "Employees",
                newName: "ReportsToEmployeeId");
        }
    }
}
