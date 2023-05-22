using TaskAssign.Models;

namespace TaskAssign.Service.Interfaces
{
	public interface ITeamMemberService
	{
		Task<TeamMember> GetTeamMemberById(int teamMemberId);
		Task<List<TeamMember>> GetTeamMembers(); 
		Task<bool> CreateTeamMember(TeamMember teamMember);
		Task<bool> UpdateTeamMember(TeamMember teamMember); 
		Task<bool> DeleteTeamMember(int teamMemberId);
	}
}
