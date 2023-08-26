using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleParking.Migrations
{
    public partial class AddEntryTimeColumnParkingSpace1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntryTime",
                table: "Vehicles");

            migrationBuilder.AddColumn<DateTime>(
                name: "EntryTime",
                table: "parkingSpaces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntryTime",
                table: "parkingSpaces");

            migrationBuilder.AddColumn<DateTime>(
                name: "EntryTime",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
