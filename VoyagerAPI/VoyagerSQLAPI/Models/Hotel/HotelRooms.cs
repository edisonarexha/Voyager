using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Hotel
{
    public class HotelRooms
    {
        [Key]
        public int RoomsId { get; set; }
        public string RoomDescription { get; set; }
        public int HotelId { get; set; }
    }
}
