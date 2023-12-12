using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlokAPI.Migrations
{
    public partial class CustomerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNum = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "Name", "PhoneNum" },
                values: new object[,]
                {
                    { 1, "carlajohns@gmail.com", "Carla Johns", "618-452-8417" },
                    { 2, "mcastillo@outlook.com", "Martin Castillo", "860-254-7331" },
                    { 3, "vincentcooper85@gmail.com", "Vincent Cooper", "841-318-9338" },
                    { 4, "cras.eget@protonmail.org", "Nora Olsen", "880-547-6442" },
                    { 5, "primis.in@yahoo.ca", "Sasha Roman", "686-168-5402" },
                    { 6, "sit.amet@outlook.com", "Erich Booker", "686-107-2226" },
                    { 7, "amet.consectetuer@protonmail.edu", "Philip Guzman", "231-874-7758" },
                    { 8, "mauris@google.net", "Tucker Wright", "823-205-3788" },
                    { 9, "jessmendoza@gmail.com", "Jessica Mendoza", "632-627-4811" },
                    { 10, "iaculis.nec@outlook.edu", "Kevin Holt", "277-175-1424" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
