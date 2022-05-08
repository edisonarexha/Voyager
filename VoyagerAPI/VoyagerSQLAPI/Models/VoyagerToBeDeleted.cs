using System.ComponentModel.DataAnnotations;

namespace VoyagerSQLAPI.Models
{
    public class VoyagerToBeDeleted
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public  VoyagerType VoyagerType { get; set; }   

        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

    }
    public enum Priority
    {
        Low, Medium, High
    }
    public enum VoyagerType
    {
        Feature,Bug,Documentation
    }
}
