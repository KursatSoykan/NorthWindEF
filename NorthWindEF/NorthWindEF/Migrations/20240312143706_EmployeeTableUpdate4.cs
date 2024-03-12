using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWindEF.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportsTo",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsToEmployeeID",
                table: "Employees",
                column: "ReportsToEmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsToEmployeeID",
                table: "Employees",
                column: "ReportsToEmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsToEmployeeID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsToEmployeeID",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ReportsTo",
                table: "Employees",
                type: "int",
                nullable: true);
        }
    }
}
