using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlokAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "Class", "ClassCode", "Color", "IsRented", "LicensePlate", "Make", "Mileage", "Model", "State", "VIN" },
                values: new object[,]
                {
                    { 1, "Standard", "SCAR", "White", true, "OR732", "Honda", 32000, "Civic", "OR", "TH829472" },
                    { 2, "Standard", "SCAR", "Black", false, "IL773", "Toyota", 18500, "Corolla", "IL", "SC232043" },
                    { 3, "Full-Size", "FCAR", "Silver", false, "CO292", "Chevrolet", 45200, "Malibu", "CO", "ST212765" },
                    { 4, "Economy", "ECAR", "Blue", true, "WA729", "Chevrolet", 27800, "Spark", "WA", "TK939284" },
                    { 5, "Luxury Convertible", "LTAR", "Gray", false, "CA728", "BMW", 221, "4-Series", "CA", "SR563809" },
                    { 6, "Large Pickup", "PPAR", "Red", false, "OR621", "Ford", 39500, "F-150", "OR", "LT281943" },
                    { 7, "Standard SUV", "SFAR", "Black", false, "CA728", "Hyundai", 52000, "Santa Fe", "CA", "SR938384" },
                    { 8, "Intermediate SUV", "IFAR", "White", false, "OR612", "Toyota", 29000, "Rav4", "OR", "LK291013" },
                    { 9, "Sport", "SSAR", "Black", false, "OR212", "Dodge", 22100, "Challenger", "OR", "HG637920" },
                    { 10, "Small Pickup", "SPAR", "White", false, "WA875", "Nissan", 3587, "Frontier", "WA", "RG587984" },
                    { 11, "Jeep Wrangler", "FJAR", "Red", false, "CA212", "Jeep", 22587, "Wrangler", "CA", "TC627912" },
                    { 12, "Minivan", "MVAR", "Gray", false, "OR973", "Chrysler", 12634, "Pacifica", "OR", "RR292721" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12);
        }
    }
}
