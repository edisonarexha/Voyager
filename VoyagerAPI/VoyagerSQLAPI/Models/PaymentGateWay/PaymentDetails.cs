using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.PaymentGateWay
{
    public class PaymentDetails
    {
        [Key]
        public Guid paymentId { get; set; }
        public int userid { get; set; }
        public string email { get; set; }
        public int ticketid { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public int hotelId { get; set; }
        public int roomid { get; set; }
        public bool adminApproved { get; set; }
        public bool isDone { get; set; }

    }
}
