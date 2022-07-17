namespace VoyagerSQLAPI.Models.Hotel
{
    public class HotelReserved
    {
        public int id { get; set; }
        public int hotelId { get; set; }

        public bool isApproved { get; set; }
        public bool isFree { get; set; }
    }
}
