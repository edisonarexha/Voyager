

using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Hotel.HotelAndRoomsProc
{
    [Microsoft.EntityFrameworkCore.Keyless]
    public class HotelAndRooms_proc
    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public int? HotelPrice { get; set; }
        public int? RoomsId { get; set; }
        public string? RoomDescription { get; set; }
    }
}
