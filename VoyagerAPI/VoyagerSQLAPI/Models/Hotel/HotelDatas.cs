﻿using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Hotel
{
    public class HotelDatas
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }   
        public string Address { get; set; }
        public string Location { get; set; }
        public int? RoomId { get; set; }


    }
}