using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "flightMasters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightAmount = table.Column<double>(type: "float", nullable: false),
                    AvailableTickets = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightMasters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "flightDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerAge = table.Column<int>(type: "int", nullable: false),
                    PassengerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofJourney = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    flightMasterID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_flightDetails_flightMasters_flightMasterID",
                        column: x => x.flightMasterID,
                        principalTable: "flightMasters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_flightDetails_flightMasterID",
                table: "flightDetails",
                column: "flightMasterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flightDetails");

            migrationBuilder.DropTable(
                name: "flightMasters");
        }
    }
}
