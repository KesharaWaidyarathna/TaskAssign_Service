using Microsoft.EntityFrameworkCore;
using TaskAssign.Models;

namespace TaskAssign.DB
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
		{
		}

		public DbSet<task> Tasks { get; set; }
		public DbSet<TeamMember> TeamMembers { get; set; }
		public DbSet<Holiday> Holidays { get; set; }
	}
}
