using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstMVC.Migrations
{
    public partial class added_relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "empDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "deptManager",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_empDeptId",
                table: "Employees",
                column: "empDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_empDeptId",
                table: "Employees",
                column: "empDeptId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_empDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_empDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "empDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "deptManager",
                table: "Department");
        }
    }
}
