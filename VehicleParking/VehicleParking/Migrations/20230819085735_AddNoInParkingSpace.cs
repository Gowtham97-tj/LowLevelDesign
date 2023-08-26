using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleParking.Migrations
{
    public partial class AddNoInParkingSpace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "parkingSpaces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParkingSpaceNo",
                table: "parkingSpaces",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "parkingSpaces");

            migrationBuilder.DropColumn(
                name: "ParkingSpaceNo",
                table: "parkingSpaces");
        }
    }
}
