using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlokAPI.Migrations
{
    public partial class EmployeeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "AspNetUsers");
        }
    }
}
