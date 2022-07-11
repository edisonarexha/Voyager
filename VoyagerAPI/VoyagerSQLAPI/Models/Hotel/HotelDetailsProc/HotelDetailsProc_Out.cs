using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Hotel.HotelDetailsProc
{
    public class HotelDetailsProc_Out
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelDesc { get; set; }
        public DateTime? InsertedDate { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int? RoomId { get; set; }

    }
}
