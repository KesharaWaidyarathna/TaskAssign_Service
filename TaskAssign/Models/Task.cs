using System.ComponentModel.DataAnnotations;

namespace TaskAssign.Models
{
    public class task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Discription { get; set; }
        [Required]
        public string StartDate { get; set; }
        public int? numberOfDays { get; set; }
        public string? CompleteDate { get; set; }

        public TeamMember  teamMember { get; set;}
    }
}
