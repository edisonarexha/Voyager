using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models.Users
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public int PackageId { get; set; }
    }
}
