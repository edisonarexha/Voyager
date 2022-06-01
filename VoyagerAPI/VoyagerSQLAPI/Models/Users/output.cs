using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Users
{
    public partial class output
    {
        [Key]
        public int userid { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
}
