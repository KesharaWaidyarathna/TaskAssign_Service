using System.ComponentModel.DataAnnotations;

namespace TaskAssign.Models
{
	public class Holiday
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public DateTime HoliyDay { get; set; }
		public string Name { get; set; }
	}
}
