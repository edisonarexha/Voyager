namespace VoyagerSQLAPI.Models.PaymentGateWay
{
    public class SuccessPaymentGateAway
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string lastname { get; set; }
        public string hotelid {get;set;}
        
        public DateTime? inserteddate { get; set; }
        public bool adminApproved { get; set; }
    }
}
