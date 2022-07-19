using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class package_detais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "packagesDatas");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "packagesDatas",
                newName: "hotelid");

            migrationBuilder.RenameColumn(
                name: "TripId",
                table: "packagesDatas",
                newName: "flightId");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "packagesDatas",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "PackagePrice",
                table: "packagesDatas",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "packagesDatas",
                newName: "photo");

            migrationBuilder.AddColumn<DateTime>(
                name: "insertedDate",
                table: "packagesDatas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedDate",
                table: "hotelDatas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "filtersout",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelPrice = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filtersout", x => x.HotelId);
                });

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
                name: "packagedetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Packagesid = table.Column<int>(type: "int", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packagedetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reservationH",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    isApproved = table.Column<bool>(type: "bit", nullable: false),
                    isFree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationH", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticketsOut",
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
                name: "filtersout");

            migrationBuilder.DropTable(
                name: "hotelandrooms");

            migrationBuilder.DropTable(
                name: "packagedetails");

            migrationBuilder.DropTable(
                name: "reservationH");

            migrationBuilder.DropTable(
                name: "ticketsOut");

            migrationBuilder.DropColumn(
                name: "insertedDate",
                table: "packagesDatas");

            migrationBuilder.RenameColumn(
                name: "hotelid",
                table: "packagesDatas",
                newName: "HotelId");

            migrationBuilder.RenameColumn(
                name: "photo",
                table: "packagesDatas",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "flightId",
                table: "packagesDatas",
                newName: "TripId");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "packagesDatas",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "packagesDatas",
                newName: "PackagePrice");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "packagesDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedDate",
                table: "hotelDatas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
