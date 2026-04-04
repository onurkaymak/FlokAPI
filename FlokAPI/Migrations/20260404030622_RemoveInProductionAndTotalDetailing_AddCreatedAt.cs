using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlokAPI.Migrations
{
    public partial class RemoveInProductionAndTotalDetailing_AddCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InProduction",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TotalDetailing",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DetailingServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DetailingServices");

            migrationBuilder.AddColumn<bool>(
                name: "InProduction",
                table: "Vehicles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalDetailing",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
