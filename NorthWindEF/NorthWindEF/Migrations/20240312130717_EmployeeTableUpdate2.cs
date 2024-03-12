using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWindEF.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportToEmployeeId",
                table: "Employees",
                newName: "ReportsToEmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeId",
                table: "Employees",
                newName: "ReportToEmployeeId");
        }
    }
}
