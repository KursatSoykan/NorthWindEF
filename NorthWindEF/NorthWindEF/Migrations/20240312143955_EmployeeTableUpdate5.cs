using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWindEF.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsToEmployeeID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeID",
                table: "Employees",
                newName: "ReportsTo");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ReportsToEmployeeID",
                table: "Employees",
                newName: "IX_Employees_ReportsTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ReportsTo",
                table: "Employees",
                newName: "ReportsToEmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                newName: "IX_Employees_ReportsToEmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsToEmployeeID",
                table: "Employees",
                column: "ReportsToEmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }
    }
}
