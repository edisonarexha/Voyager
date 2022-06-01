using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.DB
{
    public class output
    {
        [Key]
        public int userid { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
