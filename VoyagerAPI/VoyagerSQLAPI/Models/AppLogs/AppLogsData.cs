namespace VoyagerSQLAPI.Models.AppLogs
{
    public class AppLogsData
    {
        public int id { get; set; }
        public int LogsNumber { get; set; }
        public int UserId { get; set; }
        public int FormaId { get; set; }
        public int ModuliId { get; set; }
        public DateTime? InsertedDate { get; set; }
        
    }
}
