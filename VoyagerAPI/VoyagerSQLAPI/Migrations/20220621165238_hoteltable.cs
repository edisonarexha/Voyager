using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    public partial class hoteltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hotelrooms_hotelDatas_HotelDatasHotelId",
                table: "hotelrooms");

            migrationBuilder.DropIndex(
                name: "IX_hotelrooms_HotelDatasHotelId",
                table: "hotelrooms");

            migrationBuilder.DropColumn(
                name: "HotelDatasHotelId",
                table: "hotelrooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelDatasHotelId",
                table: "hotelrooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_hotelrooms_HotelDatasHotelId",
                table: "hotelrooms",
                column: "HotelDatasHotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_hotelrooms_hotelDatas_HotelDatasHotelId",
                table: "hotelrooms",
                column: "HotelDatasHotelId",
                principalTable: "hotelDatas",
                principalColumn: "HotelId");
        }
    }
}
