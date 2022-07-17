using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class reservationv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hotelandrooms",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelPrice = table.Column<int>(type: "int", nullable: true),
                    RoomsId = table.Column<int>(type: "int", nullable: true),
                    RoomDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "reservationH",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    isApproved = table.Column<bool>(type: "bit", nullable: false),
                    isFree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationH", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TicketData_OUT",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HotelPrice = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    TicketId = table.Column<int>(type: "int", nullable: true),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketNumber = table.Column<int>(type: "int", nullable: true),
                    FlightNumber = table.Column<int>(type: "int", nullable: true),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PackageId = table.Column<int>(type: "int", nullable: true),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirCraftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TailNumber = table.Column<int>(type: "int", nullable: true),
                    MAXPassagerNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hotelandrooms");

            migrationBuilder.DropTable(
                name: "reservationH");

            migrationBuilder.DropTable(
                name: "TicketData_OUT");
        }
    }
}
