using TaskAssign.Models;

namespace TaskAssign.Data.Interfaces
{
	public interface ITeamMemberRepository
	{
		Task<TeamMember> GetTeamMemberById(int teamMemberId);

		Task<List<TeamMember>> GetTeamMembers();

		Task<bool> CreateTeamMember(TeamMember teamMember);

		Task<bool> UpdateTeamMember(TeamMember teamMember);

		Task<bool> DeleteTeamMember(TeamMember teamMember);
	}
}
