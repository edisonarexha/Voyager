using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class PackagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "packagesDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    insertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotelid = table.Column<int>(type: "int", nullable: false),
                    flightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packagesDatas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "packagesDatas");
        }
    }
}
