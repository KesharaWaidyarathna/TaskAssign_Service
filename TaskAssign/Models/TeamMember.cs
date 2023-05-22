using System.ComponentModel.DataAnnotations;

namespace TaskAssign.Models
{
	public class TeamMember
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Designation { get; set; }
    }
}
