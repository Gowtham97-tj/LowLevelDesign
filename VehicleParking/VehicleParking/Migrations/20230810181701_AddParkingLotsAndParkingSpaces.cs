using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleParking.Migrations
{
    public partial class AddParkingLotsAndParkingSpaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_User_UserId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "parkingLots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parkingLots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "parkingSpaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingLotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parkingSpaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_parkingSpaces_parkingLots_ParkingLotId",
                        column: x => x.ParkingLotId,
                        principalTable: "parkingLots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parkingSpaces_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parkingSpaces_ParkingLotId",
                table: "parkingSpaces",
                column: "ParkingLotId");

            migrationBuilder.CreateIndex(
                name: "IX_parkingSpaces_VehicleId",
                table: "parkingSpaces",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_users_UserId",
                table: "Vehicles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_users_UserId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "parkingSpaces");

            migrationBuilder.DropTable(
                name: "parkingLots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_User_UserId",
                table: "Vehicles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
