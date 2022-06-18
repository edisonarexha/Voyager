using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class ApplicationLogsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appLogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogsNumber = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FormaId = table.Column<int>(type: "int", nullable: false),
                    ModuliId = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appLogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "outputTrip",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightNumber = table.Column<int>(type: "int", nullable: false),
                    AirCraftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TailNumber = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outputTrip", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appLogs");

            migrationBuilder.DropTable(
                name: "outputTrip");
        }
    }
}
