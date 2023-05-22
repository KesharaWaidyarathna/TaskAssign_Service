using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskAssign.Data.Interfaces;
using TaskAssign.DB;
using TaskAssign.Models;

namespace TaskAssign.Data.Repositories
{
	public class TeamMemberRepository: ITeamMemberRepository
	{
		private readonly ApplicationDbContext _context;
		public TeamMemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }

		public async Task<bool> CreateTeamMember(TeamMember teamMember)
		{
			try
			{
				_context.TeamMembers.Add(teamMember);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> DeleteTeamMember(TeamMember teamMember)
		{
			try
			{
				_context.TeamMembers.Remove(teamMember);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}

		public async Task<TeamMember> GetTeamMemberById(int teamMemberId)
		{
			try
			{
				return await _context.TeamMembers.FindAsync(teamMemberId);
			}
			catch
			{
				throw;
			}
		}

		public async Task<List<TeamMember>> GetTeamMembers()
		{
			try
			{
				return await _context.TeamMembers.ToListAsync();
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> UpdateTeamMember(TeamMember teamMember)
		{
			try
			{
				_context.TeamMembers.Update(teamMember);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}
	}
}
