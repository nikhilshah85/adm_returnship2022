using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstMVC.Migrations
{
    public partial class initialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptNo = table.Column<int>(type: "int", nullable: false),
                    deptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptContact = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    empNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empDesigantion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empSalary = table.Column<double>(type: "float", nullable: false),
                    empIsPermenant = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.empNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
