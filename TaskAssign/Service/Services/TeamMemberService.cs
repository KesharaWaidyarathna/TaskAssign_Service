using TaskAssign.Data.Interfaces;
using TaskAssign.Models;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Service.Services
{
	public class TeamMemberService : ITeamMemberService
	{
		private readonly ITeamMemberRepository _teamMemberRepository;
        public TeamMemberService(ITeamMemberRepository teamMemberRepository)
        {
            _teamMemberRepository = teamMemberRepository;
        }

		public async Task<bool> CreateTeamMember(TeamMember teamMember)
		{
			try
			{
				return await _teamMemberRepository.CreateTeamMember(teamMember);

			}catch 
			{
				throw;
			}
		}

		public async Task<bool> DeleteTeamMember(int teamMemberId)
		{
			try
			{
				var teamMember = await _teamMemberRepository.GetTeamMemberById(teamMemberId);
				return await _teamMemberRepository.DeleteTeamMember(teamMember);

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
				return await _teamMemberRepository.GetTeamMemberById(teamMemberId);
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
				return await _teamMemberRepository.GetTeamMembers();
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
				return await _teamMemberRepository.UpdateTeamMember(teamMember);
			}
			catch
			{
				throw;
			}
		}
	}
}
