    using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class PaymentHalfMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentdata",
                columns: table => new
                {
                    paymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ticketid = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    roomid = table.Column<int>(type: "int", nullable: false),
                    adminApproved = table.Column<bool>(type: "bit", nullable: false),
                    isDone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentdata", x => x.paymentId);
                });

            migrationBuilder.CreateTable(
                name: "paymentSucc",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotelid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inserteddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    adminApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentSucc", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentdata");

            migrationBuilder.DropTable(
                name: "paymentSucc");
        }
    }
}
